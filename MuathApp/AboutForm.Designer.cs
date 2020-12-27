namespace SmartCalculator
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.HomePageLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.DeveloperLabel = new System.Windows.Forms.Label();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.SetLangaugeButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePageLinkLabel
            // 
            resources.ApplyResources(this.HomePageLinkLabel, "HomePageLinkLabel");
            this.HomePageLinkLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.HomePageLinkLabel.Name = "HomePageLinkLabel";
            this.HomePageLinkLabel.TabStop = true;
            this.HomePageLinkLabel.UseCompatibleTextRendering = true;
            this.HomePageLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HomePageLinkLabel_LinkClicked);
            // 
            // LogoPictureBox
            // 
            resources.ApplyResources(this.LogoPictureBox, "LogoPictureBox");
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.TabStop = false;
            // 
            // DeveloperLabel
            // 
            resources.ApplyResources(this.DeveloperLabel, "DeveloperLabel");
            this.DeveloperLabel.Name = "DeveloperLabel";
            // 
            // AboutLabel
            // 
            resources.ApplyResources(this.AboutLabel, "AboutLabel");
            this.AboutLabel.Name = "AboutLabel";
            // 
            // ControlPanel
            // 
            resources.ApplyResources(this.ControlPanel, "ControlPanel");
            this.ControlPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ControlPanel.Controls.Add(this.SetLangaugeButton);
            this.ControlPanel.Controls.Add(this.OkButton);
            this.ControlPanel.Name = "ControlPanel";
            // 
            // SetLangaugeButton
            // 
            resources.ApplyResources(this.SetLangaugeButton, "SetLangaugeButton");
            this.SetLangaugeButton.BackgroundImage = global::SmartCalculator.Properties.Resources.Language_Icon;
            this.SetLangaugeButton.Name = "SetLangaugeButton";
            this.SetLangaugeButton.UseVisualStyleBackColor = true;
            this.SetLangaugeButton.Click += new System.EventHandler(this.SetLangaugeButton_Click);
            // 
            // OkButton
            // 
            resources.ApplyResources(this.OkButton, "OkButton");
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OkButton.Name = "OkButton";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.Name = "TitleLabel";
            // 
            // AboutForm
            // 
            this.AcceptButton = this.OkButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.OkButton;
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.AboutLabel);
            this.Controls.Add(this.DeveloperLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.HomePageLinkLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel HomePageLinkLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Label DeveloperLabel;
        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button SetLangaugeButton;
    }
}