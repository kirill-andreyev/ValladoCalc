using System.Globalization;
using ValladoCalc.CalculatorUIs;
using ValladoCalc.Constants;

namespace ValladoCalc
{
    public partial class ValladoCalcLauncher : Form
    {
        private readonly System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValladoCalcLauncher));

        public ValladoCalcLauncher()
        {
            InitializeComponent();

            if (Thread.CurrentThread.CurrentUICulture.Name == "ru-RU")
            {
                languageSelect.SelectedIndex = 1;
            }
            else
            {
                languageSelect.SelectedIndex = 0;
            }
        }

        private void selectMethod_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void languageSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox.AccessibilityObject.Value == resources.GetString(LauncherConstantStrings.EnglishLanguageResources))
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(LauncherConstantStrings.EnglishCulture);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(LauncherConstantStrings.EnglishCulture);
            }
            else if (comboBox.AccessibilityObject.Value == resources.GetString(LauncherConstantStrings.RussianLanguageResources))
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(LauncherConstantStrings.RussianCulture);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(LauncherConstantStrings.RussianCulture);
            }

            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void kepEqtnE_Click(object sender, EventArgs e)
        {
            Form kepEqtnE = new KepEqtnE();
            kepEqtnE.ShowDialog();
        }

        private void KepEqtnP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form kepEqtnP = new KepEqtnP();
            kepEqtnP.ShowDialog();
        }

        private void RV2COE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form RV2COE = new RV2COE();
            RV2COE.ShowDialog();
        }

        private void COE2RV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form COE2RV = new COE2RV();
            COE2RV.ShowDialog();
        }
    }
}
