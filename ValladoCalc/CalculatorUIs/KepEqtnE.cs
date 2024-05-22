using ValladoCalc.Calculators;
using ValladoCalc.Constants;
using ValladoCalc.Models;

namespace ValladoCalc.CalculatorUIs
{
    public partial class KepEqtnE : Form
    {
        private KepEqtnEModel data = new KepEqtnEModel();
        private KepEqtnEResult result = new KepEqtnEResult();
        System.ComponentModel.ComponentResourceManager _resources;
        private bool radiansOutputSelected = true;

        public KepEqtnE()
        {
            _resources = new System.ComponentModel.ComponentResourceManager(typeof(KepEqtnE));
            InitializeComponent();
        }

        private void KepEqtnE_Load(object sender, EventArgs e)
        {

        }

        private void MeanAnomalityValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                data.MeanAnomality = decimal.Parse(textBox.Text);
            }
        }

        private void AngleDimension_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox.SelectedIndex == 0)
            {
                data.AngleType = AngleDimension.Degrees;
            }
            else if (comboBox.SelectedIndex == 1)
            {
                data.AngleType = AngleDimension.Radians;
            }
        }

        private void EccentricityValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                data.Eccentricity = decimal.Parse(textBox.Text);
            }
        }

        private void ToleranceValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                data.Tolerance = decimal.Parse(textBox.Text);
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            result = Calculators.KepEqtnE.Calculate(new KepEqtnEModel(data));

            eccentricAnomalyText.Visible = true;
            eccentricAnomalyValue.Visible = true;
            DisplayResult();
        }

        private void OutputDegrees_CheckedChanged(object sender, EventArgs e)
        {
            radiansOutputSelected = false;
            if (eccentricAnomalyValue.Visible)
            {
                DisplayResult();
            }
        }

        private void OutputRadians_CheckedChanged(object sender, EventArgs e)
        {
            radiansOutputSelected = true;
            if (eccentricAnomalyValue.Visible)
            {
                DisplayResult();
            }
        }

        private void DisplayResult()
        {
            if (radiansOutputSelected)
            {
                eccentricAnomalyValue.Text = result.EccentricAnomaly.ToString();
            }
            else if (!radiansOutputSelected)
            {
                eccentricAnomalyValue.Text = Angle.ConvertToDegrees(result.EccentricAnomaly).ToString();
            }
        }
    }
}
