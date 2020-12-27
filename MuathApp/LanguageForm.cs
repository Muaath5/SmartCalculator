using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SmartCalculator
{
    public partial class LanguageForm : Form
    {
        
        private string selectedLang = "";
        // API
        /// <summary>
        /// Selected lang with two letters in lower case like: en, ar, etc.
        /// </summary>
        public string SelectedLanguage
        {
            get { return selectedLang; }
            set
            { 
                selectedLang = value;
                LanguageComboBox.SelectedItem = LanguageComboBox.FindString(selectedLang);
            }
        }

        // API
        /// <summary>
        /// Selected Index in Language Combo Box
        /// </summary>
        public int SelectedIndex
        {
            get { return LanguageComboBox.SelectedIndex; }
            set { LanguageComboBox.SelectedIndex = value; }
        }

        // API
        public static CultureInfo CurrentLang = CultureInfo.CurrentUICulture;

        public LanguageForm()
        {
            InitializeComponent();
            RefreshLanguages();
        }

        protected void RefreshLanguages()
        {
            int currentIndex = LanguageComboBox.FindString(CultureInfo.CurrentUICulture.TwoLetterISOLanguageName);
            if (currentIndex != -1)
            {
                SelectedIndex = currentIndex;
            }
            else
            {
                SelectedIndex = LanguageComboBox.FindString("العربية");
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            CultureInfo newCulture = new CultureInfo(SelectedLanguage);
            CultureInfo.CurrentUICulture = newCulture;
            Application.CurrentCulture = newCulture;
            Thread.CurrentThread.CurrentUICulture = newCulture;
            Texts.RefreshCurrentRM();
            ApplyCurrentCulture();
        }

        protected void ApplyCurrentCulture()
        {
            ApplyCultureToForm(Program.MainForm);
            foreach (Form form in Program.MainForm.OwnedForms)
            {
                ApplyCultureToForm(form);
            }
            Texts.RefreshCurrentRM();
        }

        private void ApplyCultureToForm(Form form)
        {
            ComponentResourceManager resources = new ComponentResourceManager(form.GetType());
            resources.ApplyResources(form, "$this");
            foreach (Control control in form.Controls)
            {
                ApplyResourcesToControl(control, resources);
            }
        }

        private void ApplyResourcesToControl(Control ctrl, ComponentResourceManager resources)
        {
            resources.ApplyResources(ctrl, ctrl.Name);
            if (ctrl is ComboBox listControl)
            {
                int itemsCount = listControl.Items.Count;
                listControl.Items.Clear();
                listControl.Items.Add(resources.GetString($"{listControl.Name}.Items"));
                for (int i = 1; i < itemsCount; i++)
                {
                    listControl.Items.Add(resources.GetString($"{listControl.Name}.Items{i}"));
                }
                listControl.SelectedIndex = 0;
            }
            foreach (Control item in ctrl.Controls)
            {
                ApplyResourcesToControl(item, resources);
            }
        }

        private void LanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedLanguage = GetLangID(LanguageComboBox.SelectedItem.ToString());
        }

        protected static string GetLangID(string text)
        {
            string id = text.Split(' ').Last();
            id = id.RemoveLastChar();
            id = id.Remove(0, 1);
            return id;
        }

        private void LanguageForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Helper.ShowHelp(this, Texts.GetString(Constants.GetHelpKey(AvaliableWindows.LanguageForm)), Constants.ReadMeFileName);
        }
    }
}
