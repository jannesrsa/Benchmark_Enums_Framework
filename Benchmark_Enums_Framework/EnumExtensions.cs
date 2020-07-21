using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace SourceCode.Forms.Utilities.DataProviders.Models.Extensions
{
    public static class EnumExtensions
    {
        public static string GetEnumDescription(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DisplayAttribute[] attributes = fi?.GetCustomAttributes(typeof(DisplayAttribute), false) as DisplayAttribute[];

            if (attributes?.First()?.Description != null)
            {
                return attributes?.First()?.Description;
            }

            return value.ToString();
        }

        public static string GetEnumAsString(this Enum value)
        {
            return value.ToString();
        }
    }
}