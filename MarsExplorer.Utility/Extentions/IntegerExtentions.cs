using System;
using System.Globalization;

namespace MarsExplorer.Utility.Extentions
{
    public static class IntegerExtensions
    {
        public static int ToInt32Value(this string stringValue)
        {
            if (string.IsNullOrWhiteSpace(stringValue))
                return 0;

            try
            {
                var n = 0;
                return Int32.TryParse(stringValue, out n) ? n : 0;
            }
            catch
            {
                return 0;
            }
        }

        public static int? ToInt32ValueNullable(this string stringValue)
        {
            if (string.IsNullOrWhiteSpace(stringValue))
                return null;

            try
            {
                var n = 0;
                return Int32.TryParse(stringValue, out n) ? n : 0;
            }
            catch
            {
                return null;
            }
        }

        public static double ToDoubleValue(this string stringValue)
        {
            if (string.IsNullOrWhiteSpace(stringValue))
                return 0.0;

            try
            {
                double n = 0.0;
                return double.TryParse(stringValue, NumberStyles.Float, CultureInfo.InvariantCulture, out n) ? n : 0;
            }
            catch
            {
                return 0;
            }
        }

        public static decimal ToDecimalValue(this string stringValue)
        {
            if (string.IsNullOrWhiteSpace(stringValue))
                return 0.0m;

            try
            {
                decimal n = 0.0m;
                return decimal.TryParse(stringValue, NumberStyles.Float, CultureInfo.InvariantCulture, out n) ? n : 0;
            }
            catch
            {
                return 0;
            }
        }

        public static long ToInt64Value(this string stringValue)
        {
            if (string.IsNullOrWhiteSpace(stringValue))
                return 0;

            try
            {
                Int64 n = 0;
                return Int64.TryParse(stringValue, out n) ? n : 0;
            }
            catch
            {
                return 0;
            }
        }

        public static short ToInt16Value(this string stringValue)
        {
            if (string.IsNullOrWhiteSpace(stringValue))
                return 0;

            try
            {
                return Int16.Parse(stringValue);
            }
            catch
            {
                return 0;
            }
        }
    }
}
