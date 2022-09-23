using PA_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.ComponentModel;

namespace PA_1MVC
{
    public class Controller
    {

        private BindingList<Alarm> alarms = new BindingList<Alarm>();
       
    
        private AddEditObserver addeditobserver;
        private MainObserver mainobserver;
        private bool closed = false;



        /// <summary>
        /// Initializes the delegates, binding list, the main form and starts a new thread to read alarms
        /// </summary>
        /// <param name="a">addedit delegate</param>
        /// <param name="m">mainview delegate</param>
        public Controller(AddEditObserver a, MainObserver m)
        {
            addeditobserver = a;
            mainobserver = m;
            initializeAlarms();
            alarms.AllowNew = true;
            alarms.AllowRemove = true;
            alarms.AllowEdit = true;
            mainobserver(State.START, alarms);
            new Thread(checkAlarms).Start();
        }


        /// <summary>
        /// is called on if a btton is clicked in the main form
        /// </summary>
        /// <param name="action">the action wanting to be taken</param>
        /// <param name="alarm">the alarm that is selected when the button is clicked</param>
        public void ButtonClick(Actions action, Alarm alarm)
        {
            if(action == Actions.ADD)
            {
                
                addeditobserver(null);
            }
            else if(action == Actions.EDIT)
            {
                addeditobserver(alarm);
                
            }
            else if(action == Actions.SNOOZE)
            {
                foreach(Alarm a in alarms)
                {
                    if(a == alarm)
                    {
                        a.status = Status.Snoozed;
                        a.time = DateTime.Now.AddSeconds(a.snooze);
                        mainobserver(State.START, alarms);
                    }
                }
            }
            else if(action == Actions.CLOSE)
            {
                closed = true;
            }
            else{
                foreach (Alarm a in alarms)
                {
                    if (a == alarm)
                    {
                        a.status = Status.Stopped;
                        mainobserver(State.START, alarms);

                    }
                }
            }
        }
        /// <summary>
        /// is called on if a button is clicked in the addedit view
        /// </summary>
        /// <param name="alarm"></param>
        public void AddViewButtonClick(Alarm alarm)
        {
            if (!alarms.Contains(alarm))
            {
                alarms.Add(alarm);
            }
            writeToFile();
            mainobserver(State.START, alarms);
        }
        /// <summary>
        /// parses the contents of the alarm text file and initializes the binding list
        /// </summary>
        private void initializeAlarms()
        {
            string path = Application.StartupPath + "/alarms.txt";
            StreamReader r = new StreamReader(path);

            string s = r.ReadToEnd();
            if (s != "")
            {

                string[] alarmsArray = s.Split(',');
                
                foreach (string alarm in alarmsArray)
                {

                    string[] inner = alarm.Split(';');
                    if (inner.Length == 4)
                    {
                        string[] timewo = inner[0].Split(' ');
                        string[] time = timewo[0].Split(':');

                        int hour = Convert.ToInt32(time[0]);
                        int minute = Convert.ToInt32(time[1]);
                        int snooze = Int32.Parse(inner[3]);
                        Status status = (Status)Enum.Parse(typeof(Status), inner[1]);
                        Sounds sound = (Sounds)Enum.Parse(typeof(Sounds), inner[2]);

                        DateTime t = new DateTime(2022, 1, 21, hour, minute, 0);



                        Alarm a = new Alarm(t, status,sound,snooze);
                        alarms.Add(a);
                        
                    }

                }

           
            }
            r.Close();
        }

        /// <summary>
        /// writes the array of alarms to the text file
        /// </summary>
        private void writeToFile()
        {
            string path = Application.StartupPath + "/alarms.txt";
            StreamWriter w = new StreamWriter(path);
            string s = "";
            foreach (Alarm a in alarms)
            {
                if (a != null)
                {
                    s += a.time.ToString(@"HH:mm tt") + ";" + a.status +";"+a.sound + ";" + a.snooze +",";
                }
            }
            w.Write(s);
            w.Close();
        }

        /// <summary>
        /// new thread that constantly runs to check if an alarm has allerted
        /// </summary>
        private void checkAlarms()
        {
            
            Thread.Sleep(3);
            while (true)
            {
                if (closed) {break; }
                DateTime now = DateTime.Now;
                
                foreach (Alarm currentAlarm in alarms)
                {           
                    if (currentAlarm.isTime())
                     {
                           

                        
                        currentAlarm.status = Status.Alerting;
                        mainobserver(State.ALERTING, alarms);
                         

                     }
                }
                Thread.Sleep(1);
            }
        }


    }
}
