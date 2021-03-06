﻿using System;

namespace CommonScripts.Utils
{
    public static class EnumUtils
    {
        public static T ParseOrDefault<T>(object value) where T : struct, IConvertible
        {
            return ParseOrDefault(value, default(T));
        }

        public static T ParseOrDefault<T>(object value, T defaultValue) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                throw new ArgumentException("T must be an enumerated type");

            T enumType;

            return Enum.TryParse(value.ToString(), out enumType) ? enumType : defaultValue;
        }
    }
}
