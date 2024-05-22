using ValladoCalc.Calculators;
using ValladoCalc.Models.ResultModels;
using ValladoCalc.Models.ValueModels;

namespace ValladoCalc.CalculatorUIs
{
    public partial class RV2COE : Form
    {
        private RV2COEModel data = new RV2COEModel();
        private RV2COEResult result = new RV2COEResult();
        private bool radiansOutputSelected = true;

        public RV2COE()
        {
            InitializeComponent();
        }

        private void speedVectorIValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                data.SpeedVector[0] = decimal.Parse(textBox.Text);
            }
        }

        private void speedVectorJValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                data.SpeedVector[1] = decimal.Parse(textBox.Text);
            }
        }

        private void speedVectorKValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                data.SpeedVector[2] = decimal.Parse(textBox.Text);
            }
        }

        private void radiusVectorIValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                data.RadiusVector[0] = decimal.Parse(textBox.Text);
            }
        }

        private void radiusVectorJValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                data.RadiusVector[1] = decimal.Parse(textBox.Text);
            }
        }

        private void radiusVectorKValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                data.RadiusVector[2] = decimal.Parse(textBox.Text);
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
            result = Calculators.RV2COE.Calculate(new RV2COEModel(data));

            semiParameterText.Visible = true;
            semiParameterValue.Visible = true;
            semiMajorAxisText.Visible = true;
            semiMajorAxisValue.Visible = true;
            eccentricityText.Visible = true;
            eccentricityValue.Visible = true;
            inclinationText.Visible = true;
            inclinationValue.Visible = true;
            ascendingNodeText.Visible = true;
            ascendingNodeValue.Visible = true;
            argumentOfPerigeeText.Visible = true;
            argumentOfPerigeeValue.Visible = true;
            longituteOfPerigeeText.Visible = true;
            longitudeOfPerigeeValue.Visible= true;
            trueAnomalyText.Visible = true;
            trueAnomalyValue.Visible = true;
            argumentOfLatitudeText.Visible = true;
            argumentOfLatitudeValue.Visible = true;
            trueLongitudeText.Visible = true;
            trueLongitudeValue.Visible = true;
            trueLongitudeOfPerigeeText.Visible=true;
            trueLongitudeOfPerigeeValue.Visible=true;

            eccentricityValue.Text = result.Eccentricity.ToString();
            semiMajorAxisValue.Text = result.SemiMajorAxis.ToString();
            semiParameterValue.Text = result.SemiParameter.ToString();

            DisplayAngleResult();
        }

        private void outputDegrees_CheckedChanged(object sender, EventArgs e)
        {
            radiansOutputSelected = false;
            if (semiMajorAxisText.Visible)
            {
                DisplayAngleResult();
            }
        }

        private void outputRadians_CheckedChanged(object sender, EventArgs e)
        {
            radiansOutputSelected = true;
            if(semiMajorAxisText.Visible)
            {
                DisplayAngleResult();
            }
        }

        private void DisplayAngleResult()
        {
            if (radiansOutputSelected)
            {
                inclinationValue.Text = result.Inclination.ToString();
                ascendingNodeValue.Text = result.AscendingNode.ToString();
                argumentOfPerigeeValue.Text = result.ArgumentOfPerigee.ToString();
                longitudeOfPerigeeValue.Text = result.LongituteOfPerigee.ToString();
                trueAnomalyValue.Text = result.TrueAnomaly.ToString();
                argumentOfLatitudeValue.Text = result.ArgumentOfLatitude.ToString();
                trueLongitudeValue.Text = result.TrueLongitude.ToString();
                trueLongitudeOfPerigeeValue.Text = result.TrueLongitudeOfPerigee.ToString();
            }
            else if (!radiansOutputSelected)
            {
                inclinationValue.Text = Angle.ConvertToDegrees(result.Inclination).ToString();
                ascendingNodeValue.Text = Angle.ConvertToDegrees(result.AscendingNode).ToString();
                argumentOfPerigeeValue.Text = Angle.ConvertToDegrees(result.ArgumentOfPerigee).ToString();
                longitudeOfPerigeeValue.Text = Angle.ConvertToDegrees(result.LongituteOfPerigee).ToString();
                trueAnomalyValue.Text = Angle.ConvertToDegrees(result.TrueAnomaly).ToString();
                argumentOfLatitudeValue.Text = Angle.ConvertToDegrees(result.ArgumentOfLatitude).ToString();
                trueLongitudeValue.Text = Angle.ConvertToDegrees(result.TrueLongitude).ToString();
                trueLongitudeOfPerigeeValue.Text = Angle.ConvertToDegrees(result.TrueLongitudeOfPerigee).ToString();
            }
        }
    }
}
