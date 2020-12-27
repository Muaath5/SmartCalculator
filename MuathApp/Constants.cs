using System;
using System.Globalization;
using System.Windows.Forms;

namespace SmartCalculator
{
    // API
    public static class Constants
    {
        // App info
        public const string Name = "الحاسبة الذكية";
        public const string EnglishName = "Smart Calculator";
        public const string Owner = "معاذ القرني";
        public const string Description = "آلة حاسبة ذكية";
        public const string VersionString = "9.0.0.2";
        public const string FileVersionString = VersionString;

        // Keys

        public static string GetHelpKey(AvaliableWindows form)
        {
            return form.ToString() + "Help";
        }

        public static MessageBoxOptions GetMessageBoxOptions()
        {
            if (CultureInfo.CurrentUICulture.TextInfo.IsRightToLeft)
            {
                return ArabicMessageOptions;
            }

            return 0;
        }

        public const MessageBoxOptions ArabicMessageOptions = MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading;

        // Cursors
        public const string NewAeroLink_HAND = "aero_link.cur";

        // Guid
        public static readonly byte[] BytesGuid = new byte[] { 0x95, 0xbe, 0x5c, 0x2a, 0x6a, 0x01, 40, 29, 0xb9, 0xa7, 0xea, 0xf6, 0xea, 0x6a, 76, 0xb1 };
        public const string GuidString = "95BE5C2A-6A01-4029-B9A7-EAF6EA6A76B1";
        // Example:         GuidStr2   = "0EECB5FA-50E3-43A3-8613-057837322597"
        public static readonly Guid Guid = new Guid(BytesGuid);

        // File Names
        public const string ReadMeFileName = "README.txt";
        public const string LogFileName = "Log.txt";
        public const string MemoryFileName = "Memory.txt";
        public const string VariablesFileName = "Variables.txt";

        public static readonly string[] AppliedOperations = new string[] { "+", "-", "×", "÷", "^", "√" };
        public static readonly Version Version = new Version(VersionString);
    }

    public enum AvaliableWindows
    {
        AboutForm = -1,
        MainForm = 0,
        LanguageForm = 1,
        VariablesForm, MemoryForm
    }
}
