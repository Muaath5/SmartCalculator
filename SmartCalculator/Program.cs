using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace SmartCalculator
{
    internal static class Program
    {
        internal static MainForm MainForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //ApplicationId id = new ApplicationId(Constants.BytesGuid, "الحاسبة الذكية", Constants.Version, "anycpu", "ar");
            Texts.RefreshCurrentRM();
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if DEBUG
            Application.Run(new TryForm());
#endif
            MainForm = new MainForm(args);
            Application.Run(MainForm);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Error.ShowError(null, Texts.GetString("AreYouSure"), "mailto:muaath1428@hotmail.com");
            Exception ex = e.ExceptionObject as Exception;
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Error.ShowError(null, Texts.GetString("AreYouSure"), "mailto:muaath1428@hotmail.com");
        }
    }
}
