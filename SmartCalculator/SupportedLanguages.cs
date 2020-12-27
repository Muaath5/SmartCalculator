using System.Globalization;

namespace SmartCalculator
{
    // API
    public static class SupportedLanguages
    {
        public const string Arabic = "العربية (ar)";
        //public const string ArabicCode = "ar";

        
        public const string English = "English (en)";
        //public const string EnglishCode = "en";

        public static CultureInfo GetCultureFromSupportedLanguage(string supportedLang)
        {
            return new CultureInfo(supportedLang.Substring(supportedLang.LastIndexOf('(') + 1, 2));
        }
    }
}
