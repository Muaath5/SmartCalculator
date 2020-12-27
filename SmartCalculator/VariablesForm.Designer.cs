namespace SmartCalculator
{
    partial class VariablesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VariablesForm));
            this.VariablesListView = new System.Windows.Forms.ListView();
            this.VariableColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OkButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NewValueGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ValueNumericUpDown)).BeginInit();
            this.NewValueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // VariablesListView
            // 
            resources.ApplyResources(this.VariablesListView, "VariablesListView");
            this.VariablesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.VariableColumnHeader,
            this.ValueColumnHeader});
            this.VariablesListView.FullRowSelect = true;
            this.VariablesListView.HideSelection = false;
            this.VariablesListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("VariablesListView.Items"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("VariablesListView.Items1"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("VariablesListView.Items2"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("VariablesListView.Items3")))});
            this.VariablesListView.MultiSelect = false;
            this.VariablesListView.Name = "VariablesListView";
            this.VariablesListView.ShowItemToolTips = true;
            this.VariablesListView.UseCompatibleStateImageBehavior = false;
            this.VariablesListView.View = System.Windows.Forms.View.Details;
            this.VariablesListView.SelectedIndexChanged += new System.EventHandler(this.VariablesListView_SelectedIndexChanged);
            // 
            // VariableColumnHeader
            // 
            resources.ApplyResources(this.VariableColumnHeader, "VariableColumnHeader");
            // 
            // ValueColumnHeader
            // 
            resources.ApplyResources(this.ValueColumnHeader, "ValueColumnHeader");
            // 
            // OkButton
            // 
            resources.ApplyResources(this.OkButton, "OkButton");
            this.OkButton.Name = "OkButton";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ExitButton
            // 
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ValueNumericUpDown
            // 
            resources.ApplyResources(this.ValueNumericUpDown, "ValueNumericUpDown");
            this.ValueNumericUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.ValueNumericUpDown.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.ValueNumericUpDown.Name = "ValueNumericUpDown";
            this.ValueNumericUpDown.ValueChanged += new System.EventHandler(this.ValueNumericUpDown_ValueChanged);
            // 
            // NewValueGroupBox
            // 
            resources.ApplyResources(this.NewValueGroupBox, "NewValueGroupBox");
            this.NewValueGroupBox.Controls.Add(this.ValueNumericUpDown);
            this.NewValueGroupBox.Name = "NewValueGroupBox";
            this.NewValueGroupBox.TabStop = false;
            // 
            // VariablesForm
            // 
            this.AcceptButton = this.OkButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.ExitButton;
            this.Controls.Add(this.NewValueGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.VariablesListView);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VariablesForm";
            this.ShowIcon = false;
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.VariablesForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.VariablesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ValueNumericUpDown)).EndInit();
            this.NewValueGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView VariablesListView;
        private System.Windows.Forms.ColumnHeader VariableColumnHeader;
        private System.Windows.Forms.ColumnHeader ValueColumnHeader;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.NumericUpDown ValueNumericUpDown;
        private System.Windows.Forms.GroupBox NewValueGroupBox;
    }
}