using System;
using System.Collections.Generic;

namespace BenchmarkEnumToStringDotNetStandard
{
    public static class SystemResourceInfoTypeExtensions
    {
        private static readonly Dictionary<Enum, string> _displayNames;

        static SystemResourceInfoTypeExtensions()
        {
            _displayNames = new Dictionary<Enum, string>
            {
                [SystemResourceInfoType.DateTimeNow] = "datetime-now",
                [SystemResourceInfoType.User] = "user",
                [SystemResourceInfoType.Field] = "field",
                [SystemResourceInfoType.Client] = "client",
                [SystemResourceInfoType.Error] = "error",
                [SystemResourceInfoType.RenderMode] = "rendermode",
                [SystemResourceInfoType.Workflow] = "workflow",
                [SystemResourceInfoType.ProcessActivities] = "process-activities",
                [SystemResourceInfoType.TextboxControl] = "textbox-control",
                [SystemResourceInfoType.Controls] = "controls",
                [SystemResourceInfoType.DropdownControl] = "dropdown-control",
                [SystemResourceInfoType.Folder] = "folder",
                [SystemResourceInfoType.SystemValues] = "systemvalues"
            };
        }

        public static string FromDictionary(this SystemResourceInfoType value)
        {
            string displayName;
            if (_displayNames.TryGetValue(value, out displayName))
            {
                return displayName;
            }
            return value.ToString();
        }
    }
}