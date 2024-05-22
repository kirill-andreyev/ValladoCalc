using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValladoCalc.Calculators;
using ValladoCalc.Models.ResultModels;
using ValladoCalc.Models.ValueModels;

namespace ValladoCalc.CalculatorUIs
{
    public partial class COE2RV : Form
    {
        private COE2RVModel data = new COE2RVModel();
        private COE2RVResult result = new COE2RVResult();
        private bool inputRadiansSelected = true;

        public COE2RV()
        {
            InitializeComponent();
        }

        private void COE2RV_Load(object sender, EventArgs e)
        {

        }

        private void SemiParameterValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if(decimal.TryParse(textBox.Text, out decimal value))
            {
                data.SemiParameter = decimal.Parse(textBox.Text);
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

        private void ArgumentOfPerigeeValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                data.ArgumentOfPerigee = decimal.Parse(textBox.Text);
            }
        }

        private void TrueAnomalyValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                data.TrueAnomaly = decimal.Parse(textBox.Text);
            }
        }

        private void TrueLonitudeOfPerigeeValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                data.TrueLongitude = decimal.Parse(textBox.Text);
            }
        }

        private void ArgumentOfLatitudeValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                data.ArgumentOfLatitude = decimal.Parse(textBox.Text);
            }
        }

        private void AscendingNodeValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                data.AscendingNode = decimal.Parse(textBox.Text);
            }
        }

        private void InclinationValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                data.Inclination = decimal.Parse(textBox.Text);
            }
        }

        private void TrueLongitudeValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                data.TrueLongitude = decimal.Parse(textBox.Text);
            }
        }

        private void StandardGravitationalParameterValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                data.StandardGravitationalParameter = decimal.Parse(textBox.Text);
            }
        }

        private void InputDegrees_CheckedChanged(object sender, EventArgs e)
        {
            inputRadiansSelected = false;
        }

        private void InputRadians_CheckedChanged(object sender, EventArgs e)
        {
            inputRadiansSelected = true;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            var temp = new COE2RVModel(data);

            if (!inputRadiansSelected)
            {
                temp.Inclination = Angle.ConvertToRadians(data.Inclination);
                temp.AscendingNode = Angle.ConvertToRadians(data.AscendingNode);
                temp.ArgumentOfPerigee = Angle.ConvertToRadians(data.ArgumentOfPerigee);
                temp.TrueAnomaly = Angle.ConvertToRadians(data.TrueAnomaly);
                temp.ArgumentOfLatitude = Angle.ConvertToRadians(data.ArgumentOfLatitude);
                temp.TrueLongitude = Angle.ConvertToRadians(data.TrueLongitude);
                temp.TrueLongitudeOfPerigee = Angle.ConvertToRadians(data.TrueLongitudeOfPerigee);
            }

            result = Calculators.COE2RV.Calculate(temp);

            radiusVectorText.Visible = true;
            radiusVectorIValue.Visible = true;
            radiusVectorJValue.Visible = true;
            radiusVectorKValue.Visible = true;
            speedVectorText.Visible = true;
            speedVectorIValue.Visible = true;
            speedVectorJValue.Visible = true;
            speedVectorKValue.Visible = true;
            DisplayResult();
        }

        private void DisplayResult()
        {
            radiusVectorIValue.Text = result.RadiusVector[0].ToString();
            radiusVectorJValue.Text = result.RadiusVector[1].ToString();
            radiusVectorKValue.Text = result.RadiusVector[2].ToString();
            speedVectorIValue.Text = result.SpeedVector[0].ToString();
            speedVectorJValue.Text = result.SpeedVector[1].ToString();
            speedVectorKValue.Text = result.SpeedVector[2].ToString();
        }
    }
}
