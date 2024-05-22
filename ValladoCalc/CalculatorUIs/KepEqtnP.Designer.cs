namespace ValladoCalc.CalculatorUIs
{
    partial class KepEqtnP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KepEqtnP));
            mainText = new Label();
            timeDifferenceText = new Label();
            semiParameterText = new Label();
            standardGravitationalParameterText = new Label();
            timeDifferenceValue = new TextBox();
            semiParameterValue = new TextBox();
            standardGravitationalParameterValue = new TextBox();
            calculate = new Button();
            parabolicAnomalyValue = new Label();
            timeDimension = new ComboBox();
            parabolicAnomalyText = new Label();
            outputDegrees = new RadioButton();
            outputRadians = new RadioButton();
            SuspendLayout();
            // 
            // mainText
            // 
            resources.ApplyResources(mainText, "mainText");
            mainText.Name = "mainText";
            // 
            // timeDifferenceText
            // 
            resources.ApplyResources(timeDifferenceText, "timeDifferenceText");
            timeDifferenceText.Name = "timeDifferenceText";
            // 
            // semiParameterText
            // 
            resources.ApplyResources(semiParameterText, "semiParameterText");
            semiParameterText.Name = "semiParameterText";
            // 
            // standardGravitationalParameterText
            // 
            resources.ApplyResources(standardGravitationalParameterText, "standardGravitationalParameterText");
            standardGravitationalParameterText.Name = "standardGravitationalParameterText";
            // 
            // timeDifferenceValue
            // 
            resources.ApplyResources(timeDifferenceValue, "timeDifferenceValue");
            timeDifferenceValue.Name = "timeDifferenceValue";
            timeDifferenceValue.TextChanged += timeDifferenceValue_TextChanged;
            // 
            // semiParameterValue
            // 
            resources.ApplyResources(semiParameterValue, "semiParameterValue");
            semiParameterValue.Name = "semiParameterValue";
            semiParameterValue.TextChanged += semiParameterValue_TextChanged;
            // 
            // standardGravitationalParameterValue
            // 
            resources.ApplyResources(standardGravitationalParameterValue, "standardGravitationalParameterValue");
            standardGravitationalParameterValue.Name = "standardGravitationalParameterValue";
            standardGravitationalParameterValue.TextChanged += standardGravitationalParameterValue_TextChanged;
            // 
            // calculate
            // 
            resources.ApplyResources(calculate, "calculate");
            calculate.Name = "calculate";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // parabolicAnomalyValue
            // 
            resources.ApplyResources(parabolicAnomalyValue, "parabolicAnomalyValue");
            parabolicAnomalyValue.Name = "parabolicAnomalyValue";
            // 
            // timeDimension
            // 
            timeDimension.FormattingEnabled = true;
            timeDimension.Items.AddRange(new object[] { resources.GetString("timeDimension.Items"), resources.GetString("timeDimension.Items1"), resources.GetString("timeDimension.Items2") });
            resources.ApplyResources(timeDimension, "timeDimension");
            timeDimension.Name = "timeDimension";
            timeDimension.SelectedIndexChanged += timeDimension_SelectedIndexChanged;
            // 
            // parabolicAnomalyText
            // 
            resources.ApplyResources(parabolicAnomalyText, "parabolicAnomalyText");
            parabolicAnomalyText.Name = "parabolicAnomalyText";
            // 
            // outputDegrees
            // 
            resources.ApplyResources(outputDegrees, "outputDegrees");
            outputDegrees.Name = "outputDegrees";
            outputDegrees.TabStop = true;
            outputDegrees.UseVisualStyleBackColor = true;
            outputDegrees.CheckedChanged += outputDegrees_CheckedChanged;
            // 
            // outputRadians
            // 
            resources.ApplyResources(outputRadians, "outputRadians");
            outputRadians.Name = "outputRadians";
            outputRadians.TabStop = true;
            outputRadians.UseVisualStyleBackColor = true;
            outputRadians.CheckedChanged += outputRadians_CheckedChanged;
            // 
            // KepEqtnP
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(outputRadians);
            Controls.Add(outputDegrees);
            Controls.Add(parabolicAnomalyText);
            Controls.Add(timeDimension);
            Controls.Add(parabolicAnomalyValue);
            Controls.Add(calculate);
            Controls.Add(standardGravitationalParameterValue);
            Controls.Add(semiParameterValue);
            Controls.Add(timeDifferenceValue);
            Controls.Add(standardGravitationalParameterText);
            Controls.Add(semiParameterText);
            Controls.Add(timeDifferenceText);
            Controls.Add(mainText);
            Name = "KepEqtnP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainText;
        private Label timeDifferenceText;
        private Label semiParameterText;
        private Label standardGravitationalParameterText;
        private TextBox timeDifferenceValue;
        private TextBox semiParameterValue;
        private TextBox standardGravitationalParameterValue;
        private Button calculate;
        private Label beforeCalculationResultTextRadians;
        private Label beforeCalculationResultTextDegrees;
        private Label parabolicAnomalyValue;
        private Label calculationResultDegrees;
        private ComboBox timeDimension;
        private Label parabolicAnomalyText;
        private RadioButton outputDegrees;
        private RadioButton outputRadians;
    }
}