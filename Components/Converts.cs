using System;

namespace Components
{
    public class Converts
    {
        public const double Math = 28.34952;

        public static double ConvertToOunces(double grams)
        {
            return grams / Math;
        }

        public static double ConvertToGrams(double ounces)
        {
            return ounces * Math;
        }
    }
}
