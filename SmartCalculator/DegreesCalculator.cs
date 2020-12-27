using System;

namespace SmartCalculator
{
    // API
    public static class DegreesCalculator
    {
        public const int KelvinNumber = 273;

        // API
        public static decimal CelsiusToFahrenheit(decimal temperature)
        {
            return (9 / 5 * temperature) + 32;
        }

        // API
        public static decimal FahrenheitToCelsius(decimal temperature)
        {
            return 5 / 9 * (temperature - 32);
        }

        // Extenssion Methods | API
        public static decimal ToCelisius(this string value)
        {
            decimal f;
            try
            {
                f = decimal.Parse(value.GetNaitveMathExeprission());
            }
            catch
            { throw; }

            return FahrenheitToCelsius(f);
        }
        public static decimal ToFahrenheit(this string value)
        {
            decimal c;
            try
            {
                c = decimal.Parse(value.GetNaitveMathExeprission());
            }
            catch
            { throw; }

            return FahrenheitToCelsius(c);
        }

        public static decimal ConvertDegree(DegreeType from, DegreeType to, decimal degree)
        {
            if (from == to)
            {
                return degree;
            }
#pragma warning disable CS8509 // The switch expression does not handle all possible values of its input type (it is not exhaustive).
            switch (from)
            {
                case DegreeType.Celisius:
                    return to switch
                    {
                        DegreeType.Fahrenheit => CelsiusToFahrenheit(degree),
                        DegreeType.Kelvin => degree - KelvinNumber,
                    };
                    throw new ArgumentException();

                case DegreeType.Fahrenheit:
                    decimal celsius = FahrenheitToCelsius(degree);
                    return to switch
                    {
                        DegreeType.Celisius => celsius,
                        DegreeType.Kelvin => celsius - KelvinNumber,
                    };
                    throw new ArgumentException();

                case DegreeType.Kelvin:
                    celsius = degree + KelvinNumber;
                    return to switch
                    {
                        DegreeType.Celisius => celsius,
                        DegreeType.Fahrenheit => CelsiusToFahrenheit(celsius),
                    };
                    throw new ArgumentException();
#pragma warning restore CS8509 // The switch expression does not handle all possible values of its input type (it is not exhaustive).
            }

            throw new NotImplementedException();
        }
    }

    public enum DegreeType
    {
        Celisius, Fahrenheit, Kelvin
    }
}
