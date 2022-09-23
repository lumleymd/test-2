using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_1MVC
{
    /// <summary>
    /// Enum for the status of the alarms
    /// </summary>
   public enum Status
    {
        Off,
        On,
        Snoozed,
        Alerting,
        Stopped
    }
}
