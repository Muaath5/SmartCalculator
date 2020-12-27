namespace SmartCalculator
{
    partial class MemoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryForm));
            this.DeleteAllButton = new System.Windows.Forms.Button();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.CopyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OkButton = new System.Windows.Forms.Button();
            this.MemoryListView = new System.Windows.Forms.ListView();
            this.CopyAllButton = new System.Windows.Forms.Button();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteAllButton
            // 
            resources.ApplyResources(this.DeleteAllButton, "DeleteAllButton");
            this.DeleteAllButton.ForeColor = System.Drawing.Color.Red;
            this.DeleteAllButton.Name = "DeleteAllButton";
            this.DeleteAllButton.UseVisualStyleBackColor = true;
            this.DeleteAllButton.Click += new System.EventHandler(this.DeleteAllButton_Click);
            // 
            // MainToolStrip
            // 
            resources.ApplyResources(this.MainToolStrip, "MainToolStrip");
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStripButton,
            this.DeleteToolStripButton});
            this.MainToolStrip.Name = "MainToolStrip";
            // 
            // CopyToolStripButton
            // 
            this.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.CopyToolStripButton, "CopyToolStripButton");
            this.CopyToolStripButton.Name = "CopyToolStripButton";
            this.CopyToolStripButton.Click += new System.EventHandler(this.CopyToolStripButton_Click);
            // 
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.DeleteToolStripButton, "DeleteToolStripButton");
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // OkButton
            // 
            resources.ApplyResources(this.OkButton, "OkButton");
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OkButton.Name = "OkButton";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // MemoryListView
            // 
            resources.ApplyResources(this.MemoryListView, "MemoryListView");
            this.MemoryListView.FullRowSelect = true;
            this.MemoryListView.HideSelection = false;
            this.MemoryListView.Name = "MemoryListView";
            this.MemoryListView.UseCompatibleStateImageBehavior = false;
            this.MemoryListView.View = System.Windows.Forms.View.List;
            this.MemoryListView.SelectedIndexChanged += new System.EventHandler(this.MemoryListView_SelectedIndexChanged);
            // 
            // CopyAllButton
            // 
            resources.ApplyResources(this.CopyAllButton, "CopyAllButton");
            this.CopyAllButton.Name = "CopyAllButton";
            this.CopyAllButton.UseVisualStyleBackColor = true;
            this.CopyAllButton.Click += new System.EventHandler(this.CopyAllButton_Click);
            // 
            // MemoryForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.OkButton;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.CopyAllButton);
            this.Controls.Add(this.MemoryListView);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.DeleteAllButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemoryForm";
            this.Opacity = 0.99D;
            this.Load += new System.EventHandler(this.MemoryForm_Load);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DeleteAllButton;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton CopyToolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.ListView MemoryListView;
        private System.Windows.Forms.Button CopyAllButton;
    }
}

