using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCalculator
{
    public static class Helper
    {
        public const MessageBoxOptions ArabicMessageOptions = MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading;

        
        public static void ShowHelp(IWin32Window parent, string helpText, string helpPath)
        {
            if (helpPath == null)
            {
                MessageBox.Show(parent, helpText, Texts.GetString("Help"), MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, Constants.GetMessageBoxOptions());
            }
            else
            {
                MessageBox.Show(parent, helpText, Texts.GetString("Help"), MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, Constants.GetMessageBoxOptions(), helpPath);
            }
        }
        public static DialogResult AreYouSure(IWin32Window parent, string text, MessageBoxDefaultButton defaultButton)
        {
            return MessageBox.Show(parent, text, Texts.GetString("AreYouSure"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, defaultButton, ArabicMessageOptions);
        }

        public static string GetCurrentAppInfo()
        {
            string result = "معلومات البرنامج الحالية:";
            foreach (Form item in Application.OpenForms.OfType<Form>().ToArray())
            {
                result += item.ToString();
            }
            return result;
        }

        public static string RemoveLastChar(this string str)
        {
            return str.Remove(str.Length - 1, 1);
        }

        public static string AsLines(this IEnumerable<string> value)
        {
            string result = "";

            foreach (string item in value)
            {
                result += item + Environment.NewLine;
            }

            return result;
        }

        public static IEnumerable<string> ToStringArray(this IEnumerable values)
        {
            foreach (object item in values)
            {
                if (values is Control ctrl)
                {
                    yield return ctrl.Text;
                }
                yield return item.ToString();
            }
        }
    }
}
