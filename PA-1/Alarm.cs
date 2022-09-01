using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_1
{
    public class Alarm
    {
        public DateTime time;
        public string status;
        
        /// <summary>
        /// Initailizes the alarms variables
        /// </summary>
        /// <param name="time"></param>
        /// <param name="status"></param>
        public Alarm(DateTime time, string status)
        {
            this.time = time;
            this.status = status;
            
        }
    }
}
