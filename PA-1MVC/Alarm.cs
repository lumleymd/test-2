using PA_1MVC;
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
        public Status status;
        public Sounds sound;
        public int snooze;

        /// <summary>
        /// Initailizes the alarms variables
        /// </summary>
        /// <param name="time">DateTime of the alarm</param>
        /// <param name="status">status enum for the alarm</param>
        /// <param name="sound">sound for the alrm</param>
        /// <param name="snooze">snooze time for the alarm</param>
        public Alarm(DateTime time, Status status, Sounds sound, int snooze)
        {
            this.time = time;
            this.status = status;
            this.sound = sound;
            this.snooze = snooze;

        }
        /// <summary>
        /// Checks to see if the current time is the same as the time of the alarm
        /// </summary>
        /// <returns>true if the alarm and the current time match</returns>
        public bool isTime()
        {

            if (status != Status.Off)
            {
                if (DateTime.Now.ToString(@"HH:mm:ss tt") == time.ToString(@"HH:mm:ss tt"))
                {
                    return true;

                }
            }
            return false;
        }
        /// <summary>
        /// An override to get the display string for the alarm
        /// </summary>
        /// <returns>time and status of the alarm as a string</returns>
        public override string ToString()
        {
            return time.ToString("t") + " " + status.ToString();
        }
    }
}
