namespace SmartCalculator
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CopyContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MathExeprissionLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.OpenBarcetButton = new System.Windows.Forms.Button();
            this.ClosedBarcetButton = new System.Windows.Forms.Button();
            this.SqrtButton = new System.Windows.Forms.Button();
            this.ButtonNumber0 = new System.Windows.Forms.Button();
            this.ButtonNumber1 = new System.Windows.Forms.Button();
            this.ButtonNumber2 = new System.Windows.Forms.Button();
            this.ButtonNumber3 = new System.Windows.Forms.Button();
            this.ButtonNumber4 = new System.Windows.Forms.Button();
            this.ButtonNumber5 = new System.Windows.Forms.Button();
            this.ButtonNumber6 = new System.Windows.Forms.Button();
            this.ButtonNumber7 = new System.Windows.Forms.Button();
            this.ButtonNumber8 = new System.Windows.Forms.Button();
            this.ButtonNumber9 = new System.Windows.Forms.Button();
            this.FloatPointButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.CurrentModeComboBox = new System.Windows.Forms.ComboBox();
            this.MenuButton = new System.Windows.Forms.Button();
            this.MenuItemsPanel = new System.Windows.Forms.Panel();
            this.VariablesButton = new System.Windows.Forms.Button();
            this.MemoryButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.AddToMemoryButton = new System.Windows.Forms.Button();
            this.ANSButton = new System.Windows.Forms.Button();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.PowerButton = new System.Windows.Forms.Button();
            this.VariablesPanel = new System.Windows.Forms.Panel();
            this.VarAButton = new System.Windows.Forms.Button();
            this.VarBButton = new System.Windows.Forms.Button();
            this.VarCButton = new System.Windows.Forms.Button();
            this.VarDButton = new System.Windows.Forms.Button();
            this.FromComboBox = new System.Windows.Forms.ComboBox();
            this.ToComboBox = new System.Windows.Forms.ComboBox();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.ConversionPanel = new System.Windows.Forms.Panel();
            this.DefaultOperationsPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubButton = new System.Windows.Forms.Button();
            this.MulButton = new System.Windows.Forms.Button();
            this.DivButton = new System.Windows.Forms.Button();
            this.PiButton = new System.Windows.Forms.Button();
            this.HexadecimalPanel = new System.Windows.Forms.Panel();
            this.HexAButton = new System.Windows.Forms.Button();
            this.HexDButton = new System.Windows.Forms.Button();
            this.HexCButton = new System.Windows.Forms.Button();
            this.HexBButton = new System.Windows.Forms.Button();
            this.HexEButton = new System.Windows.Forms.Button();
            this.HexFButton = new System.Windows.Forms.Button();
            this.MathExepressionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CopyContextMenuStrip.SuspendLayout();
            this.MenuItemsPanel.SuspendLayout();
            this.UpPanel.SuspendLayout();
            this.VariablesPanel.SuspendLayout();
            this.ConversionPanel.SuspendLayout();
            this.DefaultOperationsPanel.SuspendLayout();
            this.HexadecimalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CopyContextMenuStrip
            // 
            resources.ApplyResources(this.CopyContextMenuStrip, "CopyContextMenuStrip");
            this.CopyContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStripMenuItem});
            this.CopyContextMenuStrip.Name = "CopyContextMenuStrip";
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Image = global::SmartCalculator.Properties.Resources.نسخ;
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            resources.ApplyResources(this.CopyToolStripMenuItem, "CopyToolStripMenuItem");
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // MathExeprissionLabel
            // 
            resources.ApplyResources(this.MathExeprissionLabel, "MathExeprissionLabel");
            this.MathExeprissionLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MathExeprissionLabel.ContextMenuStrip = this.CopyContextMenuStrip;
            this.MathExeprissionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MathExeprissionLabel.Name = "MathExeprissionLabel";
            this.MathExeprissionLabel.TextChanged += new System.EventHandler(this.MathExeprissionLabel_TextChanged);
            // 
            // ResultLabel
            // 
            resources.ApplyResources(this.ResultLabel, "ResultLabel");
            this.ResultLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultLabel.ContextMenuStrip = this.CopyContextMenuStrip;
            this.ResultLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultLabel.Name = "ResultLabel";
            // 
            // OpenBarcetButton
            // 
            this.OpenBarcetButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.OpenBarcetButton, "OpenBarcetButton");
            this.OpenBarcetButton.Name = "OpenBarcetButton";
            this.OpenBarcetButton.UseVisualStyleBackColor = false;
            this.OpenBarcetButton.Click += new System.EventHandler(this.BarcketButton_Click);
            // 
            // ClosedBarcetButton
            // 
            this.ClosedBarcetButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.ClosedBarcetButton, "ClosedBarcetButton");
            this.ClosedBarcetButton.Name = "ClosedBarcetButton";
            this.ClosedBarcetButton.UseVisualStyleBackColor = false;
            this.ClosedBarcetButton.Click += new System.EventHandler(this.BarcketButton_Click);
            // 
            // SqrtButton
            // 
            this.SqrtButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.SqrtButton, "SqrtButton");
            this.SqrtButton.Name = "SqrtButton";
            this.SqrtButton.UseVisualStyleBackColor = false;
            this.SqrtButton.Click += new System.EventHandler(this.Operation_Click);
            // 
            // ButtonNumber0
            // 
            this.ButtonNumber0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.ButtonNumber0, "ButtonNumber0");
            this.ButtonNumber0.Name = "ButtonNumber0";
            this.ButtonNumber0.UseVisualStyleBackColor = false;
            this.ButtonNumber0.EnabledChanged += new System.EventHandler(this.ButtonNumberX_EnabledChanged);
            this.ButtonNumber0.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ButtonNumber1
            // 
            this.ButtonNumber1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.ButtonNumber1, "ButtonNumber1");
            this.ButtonNumber1.Name = "ButtonNumber1";
            this.ButtonNumber1.UseVisualStyleBackColor = false;
            this.ButtonNumber1.EnabledChanged += new System.EventHandler(this.ButtonNumberX_EnabledChanged);
            this.ButtonNumber1.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ButtonNumber2
            // 
            this.ButtonNumber2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.ButtonNumber2, "ButtonNumber2");
            this.ButtonNumber2.Name = "ButtonNumber2";
            this.ButtonNumber2.UseVisualStyleBackColor = false;
            this.ButtonNumber2.EnabledChanged += new System.EventHandler(this.ButtonNumberX_EnabledChanged);
            this.ButtonNumber2.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ButtonNumber3
            // 
            this.ButtonNumber3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.ButtonNumber3, "ButtonNumber3");
            this.ButtonNumber3.Name = "ButtonNumber3";
            this.ButtonNumber3.UseVisualStyleBackColor = false;
            this.ButtonNumber3.EnabledChanged += new System.EventHandler(this.ButtonNumberX_EnabledChanged);
            this.ButtonNumber3.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ButtonNumber4
            // 
            this.ButtonNumber4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.ButtonNumber4, "ButtonNumber4");
            this.ButtonNumber4.Name = "ButtonNumber4";
            this.ButtonNumber4.UseVisualStyleBackColor = false;
            this.ButtonNumber4.EnabledChanged += new System.EventHandler(this.ButtonNumberX_EnabledChanged);
            this.ButtonNumber4.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ButtonNumber5
            // 
            this.ButtonNumber5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.ButtonNumber5, "ButtonNumber5");
            this.ButtonNumber5.Name = "ButtonNumber5";
            this.ButtonNumber5.UseVisualStyleBackColor = false;
            this.ButtonNumber5.EnabledChanged += new System.EventHandler(this.ButtonNumberX_EnabledChanged);
            this.ButtonNumber5.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ButtonNumber6
            // 
            this.ButtonNumber6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.ButtonNumber6, "ButtonNumber6");
            this.ButtonNumber6.Name = "ButtonNumber6";
            this.ButtonNumber6.UseVisualStyleBackColor = false;
            this.ButtonNumber6.EnabledChanged += new System.EventHandler(this.ButtonNumberX_EnabledChanged);
            this.ButtonNumber6.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ButtonNumber7
            // 
            this.ButtonNumber7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.ButtonNumber7, "ButtonNumber7");
            this.ButtonNumber7.Name = "ButtonNumber7";
            this.ButtonNumber7.UseVisualStyleBackColor = false;
            this.ButtonNumber7.EnabledChanged += new System.EventHandler(this.ButtonNumberX_EnabledChanged);
            this.ButtonNumber7.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ButtonNumber8
            // 
            this.ButtonNumber8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.ButtonNumber8, "ButtonNumber8");
            this.ButtonNumber8.Name = "ButtonNumber8";
            this.ButtonNumber8.UseVisualStyleBackColor = false;
            this.ButtonNumber8.EnabledChanged += new System.EventHandler(this.ButtonNumberX_EnabledChanged);
            this.ButtonNumber8.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ButtonNumber9
            // 
            this.ButtonNumber9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.ButtonNumber9, "ButtonNumber9");
            this.ButtonNumber9.Name = "ButtonNumber9";
            this.ButtonNumber9.UseVisualStyleBackColor = false;
            this.ButtonNumber9.EnabledChanged += new System.EventHandler(this.ButtonNumberX_EnabledChanged);
            this.ButtonNumber9.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // FloatPointButton
            // 
            this.FloatPointButton.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.FloatPointButton, "FloatPointButton");
            this.FloatPointButton.Name = "FloatPointButton";
            this.FloatPointButton.UseVisualStyleBackColor = false;
            this.FloatPointButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.ClearButton, "ClearButton");
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.EqualsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.EqualsButton, "EqualsButton");
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.UseVisualStyleBackColor = false;
            this.EqualsButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // CurrentModeComboBox
            // 
            this.CurrentModeComboBox.DisplayMember = "قياسي";
            this.CurrentModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrentModeComboBox.DropDownWidth = 120;
            resources.ApplyResources(this.CurrentModeComboBox, "CurrentModeComboBox");
            this.CurrentModeComboBox.FormattingEnabled = true;
            this.CurrentModeComboBox.Items.AddRange(new object[] {
            resources.GetString("CurrentModeComboBox.Items"),
            resources.GetString("CurrentModeComboBox.Items1"),
            resources.GetString("CurrentModeComboBox.Items2")});
            this.CurrentModeComboBox.Name = "CurrentModeComboBox";
            this.CurrentModeComboBox.ValueMember = "قياسي";
            this.CurrentModeComboBox.SelectedIndexChanged += new System.EventHandler(this.CurrentMethodComboBox_SelectedIndexChanged);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.MenuButton, "MenuButton");
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // MenuItemsPanel
            // 
            this.MenuItemsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MenuItemsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuItemsPanel.Controls.Add(this.VariablesButton);
            this.MenuItemsPanel.Controls.Add(this.MemoryButton);
            this.MenuItemsPanel.Controls.Add(this.AboutButton);
            resources.ApplyResources(this.MenuItemsPanel, "MenuItemsPanel");
            this.MenuItemsPanel.Name = "MenuItemsPanel";
            // 
            // VariablesButton
            // 
            this.VariablesButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.VariablesButton, "VariablesButton");
            this.VariablesButton.Name = "VariablesButton";
            this.VariablesButton.UseVisualStyleBackColor = false;
            this.VariablesButton.Click += new System.EventHandler(this.VariablesButton_Click);
            // 
            // MemoryButton
            // 
            this.MemoryButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.MemoryButton, "MemoryButton");
            this.MemoryButton.Name = "MemoryButton";
            this.MemoryButton.UseVisualStyleBackColor = false;
            this.MemoryButton.Click += new System.EventHandler(this.MemoryButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.AboutButton, "AboutButton");
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // AddToMemoryButton
            // 
            this.AddToMemoryButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.AddToMemoryButton, "AddToMemoryButton");
            this.AddToMemoryButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddToMemoryButton.Name = "AddToMemoryButton";
            this.AddToMemoryButton.UseVisualStyleBackColor = false;
            this.AddToMemoryButton.Click += new System.EventHandler(this.AddToMemoryButton_Click);
            // 
            // ANSButton
            // 
            this.ANSButton.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.ANSButton, "ANSButton");
            this.ANSButton.Name = "ANSButton";
            this.ANSButton.UseVisualStyleBackColor = false;
            this.ANSButton.Click += new System.EventHandler(this.ANSButton_Click);
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackspaceButton.BackgroundImage = global::SmartCalculator.Properties.Resources.صورة_تراجع;
            resources.ApplyResources(this.BackspaceButton, "BackspaceButton");
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.UseVisualStyleBackColor = false;
            this.BackspaceButton.Click += new System.EventHandler(this.BackspaceButton_Click);
            // 
            // UpPanel
            // 
            this.UpPanel.Controls.Add(this.OpenBarcetButton);
            this.UpPanel.Controls.Add(this.PowerButton);
            this.UpPanel.Controls.Add(this.SqrtButton);
            this.UpPanel.Controls.Add(this.ClosedBarcetButton);
            resources.ApplyResources(this.UpPanel, "UpPanel");
            this.UpPanel.Name = "UpPanel";
            // 
            // PowerButton
            // 
            this.PowerButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.PowerButton, "PowerButton");
            this.PowerButton.Name = "PowerButton";
            this.PowerButton.UseVisualStyleBackColor = false;
            this.PowerButton.Click += new System.EventHandler(this.PowerButton_Click);
            // 
            // VariablesPanel
            // 
            this.VariablesPanel.Controls.Add(this.VarAButton);
            this.VariablesPanel.Controls.Add(this.VarBButton);
            this.VariablesPanel.Controls.Add(this.VarCButton);
            this.VariablesPanel.Controls.Add(this.VarDButton);
            resources.ApplyResources(this.VariablesPanel, "VariablesPanel");
            this.VariablesPanel.Name = "VariablesPanel";
            // 
            // VarAButton
            // 
            this.VarAButton.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.VarAButton, "VarAButton");
            this.VarAButton.Name = "VarAButton";
            this.VarAButton.UseVisualStyleBackColor = true;
            this.VarAButton.Click += new System.EventHandler(this.InsertVariableButton_Click);
            // 
            // VarBButton
            // 
            this.VarBButton.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.VarBButton, "VarBButton");
            this.VarBButton.Name = "VarBButton";
            this.VarBButton.UseVisualStyleBackColor = true;
            this.VarBButton.Click += new System.EventHandler(this.InsertVariableButton_Click);
            // 
            // VarCButton
            // 
            this.VarCButton.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.VarCButton, "VarCButton");
            this.VarCButton.Name = "VarCButton";
            this.VarCButton.UseVisualStyleBackColor = true;
            this.VarCButton.Click += new System.EventHandler(this.InsertVariableButton_Click);
            // 
            // VarDButton
            // 
            this.VarDButton.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.VarDButton, "VarDButton");
            this.VarDButton.Name = "VarDButton";
            this.VarDButton.UseVisualStyleBackColor = true;
            this.VarDButton.Click += new System.EventHandler(this.InsertVariableButton_Click);
            // 
            // FromComboBox
            // 
            this.FromComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FromComboBox.DisplayMember = "مئوية";
            this.FromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.FromComboBox, "FromComboBox");
            this.FromComboBox.FormattingEnabled = true;
            this.FromComboBox.Items.AddRange(new object[] {
            resources.GetString("FromComboBox.Items"),
            resources.GetString("FromComboBox.Items1"),
            resources.GetString("FromComboBox.Items2")});
            this.FromComboBox.Name = "FromComboBox";
            this.FromComboBox.ValueMember = "قياسي";
            this.FromComboBox.SelectedIndexChanged += new System.EventHandler(this.FromComboBox_SelectedIndexChanged);
            // 
            // ToComboBox
            // 
            this.ToComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToComboBox.DisplayMember = "فهرنهايت";
            this.ToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ToComboBox, "ToComboBox");
            this.ToComboBox.FormattingEnabled = true;
            this.ToComboBox.Items.AddRange(new object[] {
            resources.GetString("ToComboBox.Items"),
            resources.GetString("ToComboBox.Items1"),
            resources.GetString("ToComboBox.Items2")});
            this.ToComboBox.Name = "ToComboBox";
            this.ToComboBox.ValueMember = "قياسي";
            this.ToComboBox.SelectedIndexChanged += new System.EventHandler(this.ConversionComboBoxes_SelectedIndexChanged);
            // 
            // FromLabel
            // 
            resources.ApplyResources(this.FromLabel, "FromLabel");
            this.FromLabel.Name = "FromLabel";
            // 
            // ToLabel
            // 
            resources.ApplyResources(this.ToLabel, "ToLabel");
            this.ToLabel.Name = "ToLabel";
            // 
            // ConversionPanel
            // 
            this.ConversionPanel.Controls.Add(this.ToComboBox);
            this.ConversionPanel.Controls.Add(this.FromLabel);
            this.ConversionPanel.Controls.Add(this.ToLabel);
            this.ConversionPanel.Controls.Add(this.FromComboBox);
            resources.ApplyResources(this.ConversionPanel, "ConversionPanel");
            this.ConversionPanel.Name = "ConversionPanel";
            // 
            // DefaultOperationsPanel
            // 
            this.DefaultOperationsPanel.Controls.Add(this.AddButton);
            this.DefaultOperationsPanel.Controls.Add(this.SubButton);
            this.DefaultOperationsPanel.Controls.Add(this.MulButton);
            this.DefaultOperationsPanel.Controls.Add(this.DivButton);
            resources.ApplyResources(this.DefaultOperationsPanel, "DefaultOperationsPanel");
            this.DefaultOperationsPanel.Name = "DefaultOperationsPanel";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.AddButton, "AddButton");
            this.AddButton.Name = "AddButton";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.Operation_Click);
            // 
            // SubButton
            // 
            this.SubButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.SubButton, "SubButton");
            this.SubButton.Name = "SubButton";
            this.SubButton.UseVisualStyleBackColor = false;
            this.SubButton.Click += new System.EventHandler(this.Operation_Click);
            // 
            // MulButton
            // 
            this.MulButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.MulButton, "MulButton");
            this.MulButton.Name = "MulButton";
            this.MulButton.UseVisualStyleBackColor = false;
            this.MulButton.Click += new System.EventHandler(this.Operation_Click);
            // 
            // DivButton
            // 
            this.DivButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.DivButton, "DivButton");
            this.DivButton.Name = "DivButton";
            this.DivButton.UseVisualStyleBackColor = false;
            this.DivButton.Click += new System.EventHandler(this.Operation_Click);
            // 
            // PiButton
            // 
            this.PiButton.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.PiButton, "PiButton");
            this.PiButton.Name = "PiButton";
            this.PiButton.UseVisualStyleBackColor = false;
            this.PiButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // HexadecimalPanel
            // 
            this.HexadecimalPanel.Controls.Add(this.HexAButton);
            this.HexadecimalPanel.Controls.Add(this.HexDButton);
            this.HexadecimalPanel.Controls.Add(this.HexCButton);
            this.HexadecimalPanel.Controls.Add(this.HexBButton);
            this.HexadecimalPanel.Controls.Add(this.HexEButton);
            this.HexadecimalPanel.Controls.Add(this.HexFButton);
            resources.ApplyResources(this.HexadecimalPanel, "HexadecimalPanel");
            this.HexadecimalPanel.Name = "HexadecimalPanel";
            // 
            // HexAButton
            // 
            this.HexAButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.HexAButton, "HexAButton");
            this.HexAButton.Name = "HexAButton";
            this.HexAButton.UseVisualStyleBackColor = false;
            // 
            // HexDButton
            // 
            this.HexDButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.HexDButton, "HexDButton");
            this.HexDButton.Name = "HexDButton";
            this.HexDButton.UseVisualStyleBackColor = false;
            // 
            // HexCButton
            // 
            this.HexCButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.HexCButton, "HexCButton");
            this.HexCButton.Name = "HexCButton";
            this.HexCButton.UseVisualStyleBackColor = false;
            // 
            // HexBButton
            // 
            this.HexBButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.HexBButton, "HexBButton");
            this.HexBButton.Name = "HexBButton";
            this.HexBButton.UseVisualStyleBackColor = false;
            // 
            // HexEButton
            // 
            this.HexEButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.HexEButton, "HexEButton");
            this.HexEButton.Name = "HexEButton";
            this.HexEButton.UseVisualStyleBackColor = false;
            // 
            // HexFButton
            // 
            this.HexFButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.HexFButton, "HexFButton");
            this.HexFButton.Name = "HexFButton";
            this.HexFButton.UseVisualStyleBackColor = false;
            // 
            // MathExepressionRichTextBox
            // 
            this.MathExepressionRichTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MathExepressionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MathExepressionRichTextBox.ContextMenuStrip = this.CopyContextMenuStrip;
            this.MathExepressionRichTextBox.DetectUrls = false;
            resources.ApplyResources(this.MathExepressionRichTextBox, "MathExepressionRichTextBox");
            this.MathExepressionRichTextBox.Name = "MathExepressionRichTextBox";
            this.MathExepressionRichTextBox.ReadOnly = true;
            this.MathExepressionRichTextBox.ShortcutsEnabled = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.MenuItemsPanel);
            this.Controls.Add(this.MathExepressionRichTextBox);
            this.Controls.Add(this.DefaultOperationsPanel);
            this.Controls.Add(this.UpPanel);
            this.Controls.Add(this.BackspaceButton);
            this.Controls.Add(this.ANSButton);
            this.Controls.Add(this.AddToMemoryButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.CurrentModeComboBox);
            this.Controls.Add(this.PiButton);
            this.Controls.Add(this.ButtonNumber0);
            this.Controls.Add(this.ButtonNumber1);
            this.Controls.Add(this.ButtonNumber2);
            this.Controls.Add(this.ButtonNumber3);
            this.Controls.Add(this.ButtonNumber4);
            this.Controls.Add(this.ButtonNumber5);
            this.Controls.Add(this.ButtonNumber6);
            this.Controls.Add(this.ButtonNumber7);
            this.Controls.Add(this.ButtonNumber8);
            this.Controls.Add(this.ButtonNumber9);
            this.Controls.Add(this.FloatPointButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.MathExeprissionLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.VariablesPanel);
            this.Controls.Add(this.HexadecimalPanel);
            this.Controls.Add(this.ConversionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::SmartCalculator.Properties.Resources.صورة_رياضيات;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.98D;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.RightToLeftLayoutChanged += new System.EventHandler(this.MainForm_RightToLeftLayoutChanged);
            this.TextChanged += new System.EventHandler(this.MainForm_TextChanged);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.CopyContextMenuStrip.ResumeLayout(false);
            this.MenuItemsPanel.ResumeLayout(false);
            this.UpPanel.ResumeLayout(false);
            this.VariablesPanel.ResumeLayout(false);
            this.ConversionPanel.ResumeLayout(false);
            this.ConversionPanel.PerformLayout();
            this.DefaultOperationsPanel.ResumeLayout(false);
            this.HexadecimalPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // Numbers
        private System.Windows.Forms.Button ButtonNumber0;
        private System.Windows.Forms.Button ButtonNumber1;
        private System.Windows.Forms.Button ButtonNumber2;
        private System.Windows.Forms.Button ButtonNumber3;
        private System.Windows.Forms.Button ButtonNumber4;
        private System.Windows.Forms.Button ButtonNumber5;
        private System.Windows.Forms.Button ButtonNumber6;
        private System.Windows.Forms.Button ButtonNumber7;
        private System.Windows.Forms.Button ButtonNumber8;
        private System.Windows.Forms.Button ButtonNumber9;
        private System.Windows.Forms.Button FloatPointButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button ClearButton;

        // Menu strips
        private System.Windows.Forms.ContextMenuStrip CopyContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;

        // Menu panel
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Panel MenuItemsPanel;
        private System.Windows.Forms.Button MemoryButton;
        private System.Windows.Forms.Button VariablesButton;
        private System.Windows.Forms.Button AboutButton;

        private System.Windows.Forms.Button AddToMemoryButton;
        private System.Windows.Forms.Button ANSButton;
        private System.Windows.Forms.Button BackspaceButton;

        // Up panel
        private System.Windows.Forms.Panel UpPanel;
        private System.Windows.Forms.Button OpenBarcetButton;
        private System.Windows.Forms.Button ClosedBarcetButton;
        private System.Windows.Forms.Button SqrtButton;

        // Variabels
        private System.Windows.Forms.Panel VariablesPanel;
        private System.Windows.Forms.Button VarAButton;
        private System.Windows.Forms.Button VarBButton;
        private System.Windows.Forms.Button VarCButton;
        private System.Windows.Forms.Button VarDButton;

        protected System.Windows.Forms.Label ResultLabel;
        protected System.Windows.Forms.Label MathExeprissionLabel;
        private System.Windows.Forms.ComboBox FromComboBox;
        private System.Windows.Forms.ComboBox ToComboBox;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Panel ConversionPanel;
        private System.Windows.Forms.Panel DefaultOperationsPanel;
        private System.Windows.Forms.Button PowerButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubButton;
        private System.Windows.Forms.Button MulButton;
        private System.Windows.Forms.Button DivButton;
        private System.Windows.Forms.Button PiButton;
        private System.Windows.Forms.Panel HexadecimalPanel;
        private System.Windows.Forms.Button HexAButton;
        private System.Windows.Forms.Button HexDButton;
        private System.Windows.Forms.Button HexCButton;
        private System.Windows.Forms.Button HexBButton;
        private System.Windows.Forms.Button HexEButton;
        private System.Windows.Forms.Button HexFButton;
        internal System.Windows.Forms.ComboBox CurrentModeComboBox;
        private System.Windows.Forms.RichTextBox MathExepressionRichTextBox;
    }
}

