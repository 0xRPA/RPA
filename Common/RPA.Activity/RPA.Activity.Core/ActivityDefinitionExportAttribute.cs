using System;
using System.ComponentModel.Composition;

namespace RPA.Activity.Core
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false), MetadataAttribute]
    public class ActivityDefinitionExportAttribute : ExportAttribute
    {
        public ActivityDefinitionExportAttribute() : base(typeof(IActivityDefinition))
        {

        }

        [Obsolete("remoe this after deploy")]
        public ActivityDefinitionExportAttribute(string displayName, string category) : base(typeof(IActivityDefinition))
        {
            this.DisplayName = displayName;
            this.Category = category;
        }

        [Obsolete("remoe this after deploy")]
        public string DisplayName { get; set; }

        [Obsolete("remoe this after deploy")]
        public string Category { get; set; }
    }
}
