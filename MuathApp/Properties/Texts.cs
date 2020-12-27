using System.Globalization;
using System.Resources;

namespace SmartCalculator
{
    // API
    public static class Texts
    {
        private static ResourceManager CurrentResourceManager;

        public static string GetString(string key)
        {
            return CurrentResourceManager.GetString(key, CultureInfo.CurrentUICulture);
        }

        internal static void RefreshCurrentRM()
        {
            CurrentResourceManager = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName switch
            {
                "ar" => Properties.Texts_ar.ResourceManager,
                "en" => Properties.Texts_en.ResourceManager,
                // Use Arabic
                _ => Properties.Texts_ar.ResourceManager,
            };
        }
    }
}
