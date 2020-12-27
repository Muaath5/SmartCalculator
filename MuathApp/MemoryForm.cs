using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartCalculator
{
    public partial class MemoryForm : Form
    {
        public MemoryForm()
        {
            InitializeComponent();
        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            MemoryManager.Clear();
            RefreshMemoryView();
        }

        private void MemoryForm_Load(object sender, EventArgs e)
        {
            RefreshMemoryView();
        }

        public void RefreshMemoryView()
        {
            MemoryListView.Items.Clear();

            // Refill view,
            foreach (string calcItem in MemoryManager.ReadAllLines())
            {
                ListViewItem item = new ListViewItem(calcItem);
                MemoryListView.Items.Add(item);
            }
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            int count = MemoryListView.SelectedItems.Count;
            for (int i = 0; i < count; i++)
            {
                MemoryListView.Items.RemoveAt(MemoryListView.SelectedItems[0].Index);
            }
            MemoryListView.SelectedItems.Clear();
        }

        private void CopyToolStripButton_Click(object sender, EventArgs e)
        {
            if (MemoryListView.SelectedItems.Count > 0)
            {
                Clipboard.SetText(MemoryListView.SelectedItems[0].Text, TextDataFormat.UnicodeText);
            }
        }

        private void CopyAllButton_Click(object sender, EventArgs e)
        {
            string text = MemoryManager.ReadAllLines().AsLines();
            if (string.IsNullOrWhiteSpace(text))
            {
                return;
            }
            Clipboard.SetText(text, TextDataFormat.UnicodeText);
        }

        private void MemoryListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MemoryListView.SelectedItems.Count > 0)
            {
                CopyToolStripButton.Enabled   = true;
                DeleteToolStripButton.Enabled = true;
                return;
            }

            CopyToolStripButton.Enabled   = false;
            DeleteToolStripButton.Enabled = false;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            SaveCurrentView();
        }

        private void SaveCurrentView()
        {
            IEnumerable<string> lines = MemoryListView.Items.ToStringArray();
            MemoryManager.WriteLines(new List<string>(lines).ToArray());
        }
    }
}
