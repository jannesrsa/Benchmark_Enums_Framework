using System;
using System.Collections.Generic;

namespace SourceCode.Forms.Utilities.DataProviders.Models.Extensions
{
    public static class SystemResourceInfoTypeExtension
    {
        private static Dictionary<Enum, string> _displayNames;

        static SystemResourceInfoTypeExtension()
        {
            _displayNames = new Dictionary<Enum, string>();
            _displayNames[SystemResourceInfoType.DateTimeNow] = "datetime-now";
            _displayNames[SystemResourceInfoType.User] = "user";
            _displayNames[SystemResourceInfoType.Field] = "field";
            _displayNames[SystemResourceInfoType.Client] = "client";
            _displayNames[SystemResourceInfoType.Error] = "error";
            _displayNames[SystemResourceInfoType.RenderMode] = "rendermode";
            _displayNames[SystemResourceInfoType.Workflow] = "workflow";
            _displayNames[SystemResourceInfoType.ProcessActivities] = "process-activities";
            _displayNames[SystemResourceInfoType.TextboxControl] = "textbox-control";
            _displayNames[SystemResourceInfoType.Controls] = "controls";
            _displayNames[SystemResourceInfoType.DropdownControl] = "dropdown-control";
            _displayNames[SystemResourceInfoType.Folder] = "folder";
            _displayNames[SystemResourceInfoType.SystemValues] = "systemvalues";
        }

        public static string GetDisplayName(this SystemResourceInfoType value)
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