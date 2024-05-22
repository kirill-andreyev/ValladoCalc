namespace ValladoCalc.CalculatorUIs
{
    partial class KepEqtnE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KepEqtnE));
            meanAnomalityValue = new TextBox();
            angleDimension = new ComboBox();
            eccentricityValue = new TextBox();
            toleranceValue = new TextBox();
            upperText = new Label();
            meanAnomality = new Label();
            eccentricity = new Label();
            tolerance = new Label();
            calculate = new Button();
            eccentricAnomalyValue = new Label();
            eccentricAnomalyText = new Label();
            outputDegrees = new RadioButton();
            outputRadians = new RadioButton();
            SuspendLayout();
            // 
            // meanAnomalityValue
            // 
            resources.ApplyResources(meanAnomalityValue, "meanAnomalityValue");
            meanAnomalityValue.Name = "meanAnomalityValue";
            meanAnomalityValue.TextChanged += MeanAnomalityValue_TextChanged;
            // 
            // angleDimension
            // 
            angleDimension.FormattingEnabled = true;
            angleDimension.Items.AddRange(new object[] { resources.GetString("angleDimension.Items"), resources.GetString("angleDimension.Items1") });
            resources.ApplyResources(angleDimension, "angleDimension");
            angleDimension.Name = "angleDimension";
            angleDimension.SelectedIndexChanged += AngleDimension_SelectedIndexChanged;
            // 
            // eccentricityValue
            // 
            resources.ApplyResources(eccentricityValue, "eccentricityValue");
            eccentricityValue.Name = "eccentricityValue";
            eccentricityValue.TextChanged += EccentricityValue_TextChanged;
            // 
            // toleranceValue
            // 
            resources.ApplyResources(toleranceValue, "toleranceValue");
            toleranceValue.Name = "toleranceValue";
            toleranceValue.TextChanged += ToleranceValue_TextChanged;
            // 
            // upperText
            // 
            resources.ApplyResources(upperText, "upperText");
            upperText.Name = "upperText";
            // 
            // meanAnomality
            // 
            resources.ApplyResources(meanAnomality, "meanAnomality");
            meanAnomality.Name = "meanAnomality";
            // 
            // eccentricity
            // 
            resources.ApplyResources(eccentricity, "eccentricity");
            eccentricity.Name = "eccentricity";
            // 
            // tolerance
            // 
            resources.ApplyResources(tolerance, "tolerance");
            tolerance.Name = "tolerance";
            // 
            // calculate
            // 
            resources.ApplyResources(calculate, "calculate");
            calculate.Name = "calculate";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += Calculate_Click;
            // 
            // eccentricAnomalyValue
            // 
            resources.ApplyResources(this.eccentricAnomalyValue, "eccentricAnomalyValue");
            this.eccentricAnomalyValue.Name = "eccentricAnomalyValue";
            // 
            // eccentricAnomalyText
            // 
            resources.ApplyResources(eccentricAnomalyText, "eccentricAnomalyText");
            eccentricAnomalyText.Name = "eccentricAnomalyText";
            // 
            // outputDegrees
            // 
            resources.ApplyResources(outputDegrees, "outputDegrees");
            outputDegrees.Name = "outputDegrees";
            outputDegrees.TabStop = true;
            outputDegrees.UseVisualStyleBackColor = true;
            outputDegrees.CheckedChanged += OutputDegrees_CheckedChanged;
            // 
            // outputRadians
            // 
            resources.ApplyResources(outputRadians, "outputRadians");
            outputRadians.Name = "outputRadians";
            outputRadians.TabStop = true;
            outputRadians.UseVisualStyleBackColor = true;
            outputRadians.CheckedChanged += OutputRadians_CheckedChanged;
            // 
            // KepEqtnE
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(outputRadians);
            Controls.Add(outputDegrees);
            Controls.Add(eccentricAnomalyText);
            Controls.Add(this.eccentricAnomalyValue);
            Controls.Add(calculate);
            Controls.Add(tolerance);
            Controls.Add(eccentricity);
            Controls.Add(meanAnomality);
            Controls.Add(upperText);
            Controls.Add(toleranceValue);
            Controls.Add(eccentricityValue);
            Controls.Add(angleDimension);
            Controls.Add(meanAnomalityValue);
            Name = "KepEqtnE";
            Load += KepEqtnE_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox meanAnomalityValue;
        private ComboBox angleDimension;
        private TextBox eccentricityValue;
        private TextBox toleranceValue;
        private Label upperText;
        private Label meanAnomality;
        private Label eccentricity;
        private Label tolerance;
        private Button calculate;
        private Label eccentricAnomalyValue;
        private Label calculationResultRadians;
        private Label beforeCalculationResultTextRadians;
        private Label calculationResultDegrees;
        private Label beforeCalculationResultTextDegrees;
        private Label eccentricAnomalyText;
        private RadioButton outputDegrees;
        private RadioButton outputRadians;
    }
}