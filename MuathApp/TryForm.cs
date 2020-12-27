using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using SuperControls;

namespace SmartCalculator
{
    public partial class TryForm : Form
    {
        bool IsOpened = true;
        ///*!!!*/const int speed = 250;

        public TryForm()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            //MenuButton.AnimateWindow(AnimateWindowFlags.Contract, 200);
            //MenuButton.AnimateWindow(AnimateWindowFlags.Expand, 200);

            if (IsOpened)
            {
                IsOpened = false;
                MenuItemsPanel.AnimateWindow(AnimationFlags.Slide | AnimationFlags.Hide | AnimationFlags.Left, (int)numericUpDown1.Value);
                return;
            }
            else
            {
                IsOpened = true;
                MenuItemsPanel.AnimateWindow(AnimationFlags.Slide | AnimationFlags.Activate | AnimationFlags.Right, (int)numericUpDown1.Value);
            }
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider1.SetError(textBox1, "Error");
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void TryForm_Load(object sender, EventArgs e)
        {

            //MessageBox.Show(this, "خطأ في تنزيل الملف!\r\nفضلاً اختر...", null, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            //MessageBox.Show(this, "هل تريد حفظ الملف؟؟", "تنبيه", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

            propertyGrid1.PropertyTabs.AddTabType(typeof(Form));
            propertyGrid1.SelectedObject = progressBar1;
            var rowT = new DataGridViewRow();
           
        }

        private void PiButton_Click(object sender, EventArgs e)
        {

        }
    }
}
