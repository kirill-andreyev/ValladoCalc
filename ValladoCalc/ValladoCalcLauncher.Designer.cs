using ValladoCalc.Constants;

namespace ValladoCalc
{
    partial class ValladoCalcLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValladoCalcLauncher));
            selectMethodText = new Label();
            languageSelect = new ComboBox();
            kepEqtnE = new LinkLabel();
            KepEqtnP = new LinkLabel();
            RV2COE = new LinkLabel();
            COE2RV = new LinkLabel();
            SuspendLayout();
            // 
            // selectMethodText
            // 
            resources.ApplyResources(selectMethodText, "selectMethodText");
            selectMethodText.Name = "selectMethodText";
            // 
            // languageSelect
            // 
            languageSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            languageSelect.FormattingEnabled = true;
            languageSelect.Items.AddRange(new object[] { resources.GetString("languageSelect.Items"), resources.GetString("languageSelect.Items1") });
            resources.ApplyResources(languageSelect, "languageSelect");
            languageSelect.Name = "languageSelect";
            languageSelect.SelectedIndexChanged += languageSelect_SelectedIndexChanged;
            // 
            // kepEqtnE
            // 
            resources.ApplyResources(kepEqtnE, "kepEqtnE");
            kepEqtnE.LinkBehavior = LinkBehavior.NeverUnderline;
            kepEqtnE.LinkColor = Color.Black;
            kepEqtnE.Name = "kepEqtnE";
            kepEqtnE.TabStop = true;
            kepEqtnE.VisitedLinkColor = Color.Black;
            kepEqtnE.Click += kepEqtnE_Click;
            // 
            // KepEqtnP
            // 
            resources.ApplyResources(KepEqtnP, "KepEqtnP");
            KepEqtnP.LinkBehavior = LinkBehavior.NeverUnderline;
            KepEqtnP.LinkColor = Color.Black;
            KepEqtnP.Name = "KepEqtnP";
            KepEqtnP.TabStop = true;
            KepEqtnP.VisitedLinkColor = Color.Black;
            KepEqtnP.LinkClicked += KepEqtnP_LinkClicked;
            // 
            // RV2COE
            // 
            resources.ApplyResources(RV2COE, "RV2COE");
            RV2COE.LinkBehavior = LinkBehavior.NeverUnderline;
            RV2COE.LinkColor = Color.Black;
            RV2COE.Name = "RV2COE";
            RV2COE.TabStop = true;
            RV2COE.VisitedLinkColor = Color.Black;
            RV2COE.LinkClicked += RV2COE_LinkClicked;
            // 
            // COE2RV
            // 
            resources.ApplyResources(COE2RV, "COE2RV");
            COE2RV.LinkBehavior = LinkBehavior.NeverUnderline;
            COE2RV.LinkColor = Color.Black;
            COE2RV.Name = "COE2RV";
            COE2RV.TabStop = true;
            COE2RV.VisitedLinkColor = Color.Black;
            COE2RV.LinkClicked += COE2RV_LinkClicked;
            // 
            // ValladoCalcLauncher
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(COE2RV);
            Controls.Add(RV2COE);
            Controls.Add(KepEqtnP);
            Controls.Add(kepEqtnE);
            Controls.Add(languageSelect);
            Controls.Add(selectMethodText);
            ForeColor = SystemColors.ControlText;
            Name = "ValladoCalcLauncher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label selectMethodText;
        private ComboBox languageSelect;
        private LinkLabel kepEqtnE;
        private LinkLabel KepEqtnP;
        private LinkLabel RV2COE;
        private LinkLabel COE2RV;
    }
}