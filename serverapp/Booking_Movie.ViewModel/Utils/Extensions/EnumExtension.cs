﻿using Booking_Movie.ViewModel.Utils.Attributes;
using System.Reflection;

namespace Booking_Movie.ViewModel.Utils.Extensions
{
    public static class EnumExtension
    {
        public static string? GetStringValue(this Enum value)
        {
            Type type = value.GetType();
            FieldInfo? fieldInfo = type.GetField(value.ToString());

            StringValueAttribute[]? attribs = fieldInfo?.GetCustomAttributes(
                typeof(StringValueAttribute), false) as StringValueAttribute[];

            return attribs?.Length > 0 ? attribs[0].Value : null;
        }
    }
}