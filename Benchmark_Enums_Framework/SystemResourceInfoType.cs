using System.ComponentModel.DataAnnotations;

namespace SourceCode.Forms.Utilities.DataProviders.Models
{
    public enum SystemResourceInfoType
    {
        [Display(Description = "datetime-now")]
        DateTimeNow = 1,

        [Display(Description = "user")]
        User,

        [Display(Description = "field")]
        Field,

        [Display(Description = "client")]
        Client,

        [Display(Description = "error")]
        Error,

        [Display(Description = "rendermode")]
        RenderMode,

        [Display(Description = "workflow")]
        Workflow,

        [Display(Description = "process-activities")]
        ProcessActivities,

        [Display(Description = "textbox-control")]
        TextboxControl,

        [Display(Description = "controls")]
        Controls,

        [Display(Description = "dropdown-control")]
        DropdownControl,

        [Display(Description = "folder")]
        Folder,

        [Display(Description = "systemvalues")]
        SystemValues
    }
}