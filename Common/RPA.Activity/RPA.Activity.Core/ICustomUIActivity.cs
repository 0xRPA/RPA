using System;
using System.Collections.Generic;

namespace RPA.Activity.Core
{
    public interface ICustomUIActivity
    {
        Action<ExecuteContext> Executing { get; set; }
        Action<ExecuteContext> Executed { get; set; }
        bool CreateViewNeeded { get; }
        IEnumerable<ViewBindingInfo> CreateViewBindings();
    }
}
