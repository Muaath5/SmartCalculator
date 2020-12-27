using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SmartCalculator
{
    public partial class VariablesForm : Form
    {
        public VariablesForm()
        {
            InitializeComponent();
        }

        private void ValueNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (VariablesListView.SelectedItems.Count > 0)
            {
                VariablesListView.SelectedItems[0].SubItems[1].Text = ValueNumericUpDown.Value.ToString();
            }
        }

        private void VariablesForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Helper.ShowHelp(this, Texts.GetString(Constants.GetHelpKey(AvaliableWindows.VariablesForm)), Constants.ReadMeFileName);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < VariablesManager.Variables.Length; i++)
            {
                VariablesManager.SetValue(new Variable(VariablesManager.Variables[i], decimal.Parse(VariablesListView.Items[i].SubItems[1].Text)));
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VariablesForm_Load(object sender, EventArgs e)
        {
            Variable[] vars = null;

            try
            {
                vars = VariablesManager.ReadVariables();
            }
            catch (ArgumentOutOfRangeException)
            {
                Error.ShowError(this, "خطأ في ملف المتغيرات! \r\n يجب أن تكون عدد الأسطر أربعة! \r\n ويجب أن تكون بهذا الشكل \r\n أ:0\r\nب:0\r\nج:0\r\nد:0", VariablesManager.FileName);
            }

            for (int i = 0; i < 4; i++)
            {
                VariablesListView.Items[i].SubItems.Add(new ListViewItem.ListViewSubItem(VariablesListView.Items[i], vars[i].Value.ToString()));
            }
        }

        private void VariablesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VariablesListView.SelectedItems.Count < 1)
            {
                ValueNumericUpDown.Value = 0;
                ValueNumericUpDown.Enabled = false;
            }
            else
            {
                ValueNumericUpDown.Enabled = true;
                ValueNumericUpDown.Value = decimal.Parse(VariablesListView.SelectedItems[0].SubItems[1].Text);
            }
        }
    }
}
