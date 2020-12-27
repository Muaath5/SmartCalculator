using System;
using System.Windows.Forms;

namespace SmartCalculator
{
    public static class Error
    {
        public static void ThrowError(ApplicationErrors error, params object[] data)
        {
#if DEBUG
            SmartCalculatorException ex = GetException(error, data);
            if (ex.Message.StartsWith("Unknown error, "))
            {
                LogException(ex);
            }
            throw ex;
#else
            ShowError(null, Texts.GetString(error.ToString()), Constants.ReadMeFileName);
#endif
        }

        public static void ShowError(IWin32Window parent, string message, string helpPath)
        {
            if (string.IsNullOrWhiteSpace(helpPath))
            {
                MessageBox.Show(parent, message, null, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, Constants.GetMessageBoxOptions());
            }

            MessageBox.Show(parent, message, null, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, Constants.GetMessageBoxOptions(), helpPath);
        }

        public static void ShowError(string key)
        {
            //ShowError(Program.MainForm.OwnedForms.ForEach());
        }

        private static void ShowError(object v)
        {
            throw new NotImplementedException();
        }

        public static void ShowWarning(IWin32Window parent, string message, string helpPath)
        {
            if (string.IsNullOrWhiteSpace(helpPath))
            {
                MessageBox.Show(parent, message, Texts.GetString("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, Constants.GetMessageBoxOptions());
            }
            MessageBox.Show(parent, message, Texts.GetString("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, Constants.GetMessageBoxOptions(), helpPath);
        }

#if true // Debug
        public static SmartCalculatorException GetException(ApplicationErrors error, params object[] data)
        {
            return error switch
            {
                ApplicationErrors.ConversionError => new ConversionException(Program.MainForm.CurrentModeComboBox.SelectedItem.ToString()),
                ApplicationErrors.CalculatingError => new CalculatingException(Texts.GetString(error.ToString())) { HelpLink = Constants.ReadMeFileName },
                ApplicationErrors.OperationError => new SmartCalculatorException(Program.MainForm),
                ApplicationErrors.ReadingFileError => new ReadingFileException("ReadingFileError", data[0].ToString()),
                ApplicationErrors.UnknownError => new SmartCalculatorException("Unknown error, Send to muaath1428@hotmail.com") { Window = Form.ActiveForm },
                _ => throw new ArgumentException("Not supported error!", nameof(error)),
            };
        }
#endif

        public static void LogException(SmartCalculatorException exception)
        {
            
        }

        public static void ShowError(SmartCalculatorException exception)
        {
            ShowError(exception.Window, exception.Message, exception.HelpLink);
        }
    }
}
