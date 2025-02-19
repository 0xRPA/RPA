using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPA.Activity.Core
{
    public sealed class ExecuteContext
    {
        public ExecuteContext(string instanceId)
        {
            this.InstanceId = instanceId;
        }

        public string InstanceId { get; private set; }
    }
}
