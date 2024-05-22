using System.ComponentModel;
using ValladoCalc.Calculators;
using ValladoCalc.Models;

namespace ValladoCalc.CalculatorUIs
{
    public partial class KepEqtnP : Form
    {
        private KepEqtnPModel data = new KepEqtnPModel();
        private KepEqtnPResult result = new KepEqtnPResult();
        private ComponentResourceManager resources = new ComponentResourceManager(typeof(KepEqtnP));
        private bool radiansOutputSelected = true;

        public KepEqtnP()
        {
            InitializeComponent();
        }

        private void timeDifferenceValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                data.TimeDifference = decimal.Parse(textBox.Text);
            }
        }

        private void semiParameterValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                data.SemiParameter = decimal.Parse(textBox.Text);
            }
        }

        private void standardGravitationalParameterValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                data.StandardGravitationalParameter = decimal.Parse(textBox.Text);
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            result = Calculators.KepEqtnP.Calculate(new KepEqtnPModel(data));
            parabolicAnomalyText.Visible = true;
            parabolicAnomalyValue.Visible = true;
            DisplayResult();
        }

        private void timeDimension_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combobox = sender as ComboBox;

            if (combobox.SelectedIndex == 0)
            {
                data.TimeDimension = Models.TimeDimension.Hours;
            }
            else if (combobox.SelectedIndex == 1)
            {
                data.TimeDimension = Models.TimeDimension.Minutes;
            }
            else
            {
                data.TimeDimension = Models.TimeDimension.Seconds;
            }
        }

        private void outputDegrees_CheckedChanged(object sender, EventArgs e)
        {
            radiansOutputSelected = false;
            if (parabolicAnomalyText.Visible)
            {
                DisplayResult();
            }
        }

        private void outputRadians_CheckedChanged(object sender, EventArgs e)
        {
            radiansOutputSelected = true;
            if (parabolicAnomalyText.Visible)
            {
                DisplayResult();
            }
        }

        private void DisplayResult()
        {
            if(radiansOutputSelected)
            {
                parabolicAnomalyValue.Text = result.ParabolicAnomaly.ToString();
            }
            else if(!radiansOutputSelected)
            {
                parabolicAnomalyValue.Text = Angle.ConvertToDegrees(result.ParabolicAnomaly).ToString();
            }
        }
    }
}
