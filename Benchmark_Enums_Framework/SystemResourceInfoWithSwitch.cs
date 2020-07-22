namespace SourceCode.Forms.Utilities.DataProviders.Models.Extensions
{
    public static class SystemResourceInfoWithSwitch
    {
        public static string GetDisplayNameWithSwitch(this SystemResourceInfoType value)
        {
            switch (value)
            {
                case SystemResourceInfoType.DateTimeNow:
                    return "datetime-now";

                case SystemResourceInfoType.User:
                    return "user";

                case SystemResourceInfoType.Field:
                    return "field";

                case SystemResourceInfoType.Client:
                    return "client";

                case SystemResourceInfoType.Error:
                    return "error";

                case SystemResourceInfoType.RenderMode:
                    return "rendermode";

                case SystemResourceInfoType.Workflow:
                    return "workflow";

                case SystemResourceInfoType.ProcessActivities:
                    return "process-activities";

                case SystemResourceInfoType.TextboxControl:
                    return "textbox-control";

                case SystemResourceInfoType.Controls:
                    return "controls";

                case SystemResourceInfoType.DropdownControl:
                    return "dropdown-control";

                case SystemResourceInfoType.Folder:
                    return "folder";

                case SystemResourceInfoType.SystemValues:
                    return "systemvalues";

                default:
                    return "datetime-now";
            }
        }
    }
}