using System;

namespace MarsExplorer.Utility.Extentions
{
    public static class EnumExtensions
    {
        public static Int32 ToInt32(this Enum value)
        {
            return Convert.ToInt32(value);
        }

        public static byte ToByte(this Enum value)
        {
            return Convert.ToByte(value);
        }

        public static sbyte ToSByte(this Enum value)
        {
            return Convert.ToSByte(value);
        }

        public static T FromString<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }
    }
}
