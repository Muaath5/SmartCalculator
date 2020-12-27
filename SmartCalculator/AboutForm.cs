using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SmartCalculator
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void HomePageLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://muaath.rf.gd/calculator_app.html");
        }

        private void SetLangaugeButton_Click(object sender, EventArgs e)
        {
            LanguageForm lf = new LanguageForm();
            lf.ShowDialog(this);
        }
    }
}
