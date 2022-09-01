using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Threading;
using System.Reflection;

namespace PA_1
{
    public partial class Main : Form
    {
        //array of up to 10 alarms
        public Alarm[] ar = new Alarm[10];
        //If an alarm is allerting the array position is stored here
        int currentAlert = -1;

        /// <summary>
        /// Initializes the form
        /// fills the list from stored json
        /// starts its check for alerted alarms
        /// </summary>
        public Main()
        {
            InitializeComponent();
            parseJSON();
            
            new Thread(checkAlarms).Start();
        }

      

        /// <summary>
        /// is called someone clicks the edit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void edit_button_Click(object sender, EventArgs e)
        {
            int alarmnum = alarm_list.SelectedIndex;
            Form f = new Add_Edit(alarmnum,this);
            f.ShowDialog();

        }
        /// <summary>
        /// is called when someone hits the add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_button_Click(object sender, EventArgs e)
        {
           
            Form f = new Add_Edit(-1,this);
            f.ShowDialog();


        }
        /// <summary>
        /// is called when the user hits the stop button, for stopping the allerted alarm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stop_button_Click(object sender, EventArgs e)
        {
            ar[currentAlert].status = "Stopped";
            status_label.Text = "";
            snooze_button.Enabled = false;
            stop_button.Enabled = false;
            initializeAlarms();

        }
        /// <summary>
        /// snoozes the allerting alarm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void snooze_button_Click(object sender, EventArgs e)
        {
            ar[currentAlert].status = "Snoozed";
            status_label.Text = "";
            
            snooze_button.Enabled = false;
            stop_button.Enabled = false;
            ar[currentAlert].time = DateTime.Now.AddSeconds(3);
            initializeAlarms();
        }
        /// <summary>
        /// fills the list with the alarms within the text file
        /// </summary>
        public void initializeAlarms()
        {
            alarm_list.Items.Clear();

            foreach (Alarm a in ar)
            {
                
                if(a != null)
                {
                    int hour = a.time.Hour;
                    int minute = a.time.Minute;
                    string min = minute.ToString();
                    if(minute < 10)
                    {
                        min = "0" +minute.ToString();
                    }
                    if(hour >= 13)
                    {
                        hour -= 12;
                    }
       
                    alarm_list.Items.Add(hour.ToString()+":"+ min + " " + a.time.ToString("tt")+ " " + a.status);
                }
                
            }


        }
        /// <summary>
        /// parses the contents of the alarm text file
        /// </summary>
        public void parseJSON()
        {
            string path = Application.StartupPath + "/alarms.txt";
            StreamReader r = new StreamReader(path);
            
            string s = r.ReadToEnd();
            if (s != "")
            {

                string[] alarms = s.Split(',');
                int i = 0;
                foreach (string alarm in alarms)
                {
                   
                    string[] inner = alarm.Split(';');
                    if(inner.Length == 2)
                    {
                        string[] timewo = inner[0].Split(' ');
                        string[] time = timewo[0].Split(':');
                        int hour = Convert.ToInt32(time[0]) ;
                       
                        int minute = Convert.ToInt32(time[1]);
                        
                        DateTime t = new DateTime(2022, 1, 21, hour,minute, 0);
                      
                        

                        Alarm a = new Alarm(t, inner[1]);
                        ar[i] = a;
                        i++;
                    }
                    
                }
                
                initializeAlarms();
            }
            r.Close();




        }
        /// <summary>
        /// edits a specific alarm with the desired changes
        /// </summary>
        /// <param name="num"></param>
        /// <param name="time"></param>
        /// <param name="status"></param>
        public void editAlarm(int num, DateTime time, string status)
        {

            ar[num].time = time;
            ar[num].status = status;
            alarm_list.Items.Clear();
            write();
            initializeAlarms();
        }
        /// <summary>
        /// adds an alarm to the array of alarms
        /// </summary>
        /// <param name="time"></param>
        /// <param name="status"></param>
        public void addAlarm(DateTime time, string status)
        {

            for(int i = 0; i < ar.Length; i++)
            {

                if (ar[i] == null)
                {
                    Alarm a = new Alarm(time, status);
                    ar[i] = a;
                    break;
                }

            }
            alarm_list.Items.Clear();
            write();
            initializeAlarms();
        }
        /// <summary>
        /// writes the array of alarms to the text file
        /// </summary>
        public void write()
        {
            string path = Application.StartupPath + "/alarms.txt";
            StreamWriter w = new StreamWriter(path);
            string s="";
            foreach(Alarm a in ar)
            {
                if(a != null)
                {
                    s += a.time.ToString(@"HH:mm tt") + ";" + a.status + ",";
                }
            }
            w.Write(s);
            w.Close();
        }
        /// <summary>
        /// enables the edit button if someone selects a alarm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void alarm_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            edit_button.Enabled = true;
        }


       /// <summary>
       /// new thread that constantly runs to check if an alarm has allerted
       /// </summary>
        public void checkAlarms()
        {
            Thread.Sleep(3);
            while (true)
            {

                
                if (this.Visible == false) { break; }
                DateTime now = DateTime.Now;
                int i = 0;
                foreach (Alarm currentAlarm in ar)
                {
                    
                    if (currentAlarm != null)
                    {
                        
                        if (now.ToString(@"HH:mm:ss tt") == currentAlarm.time.ToString(@"HH:mm:ss tt") && currentAlarm.status != "Off")
                        {
                            currentAlert = i;

                            currentAlarm.status = "Alerting";
                            Invoke(new Action(() => {
                                status_label.Text = "Alarm is going OFF";
                                
                                stop_button.Enabled = true;
                                snooze_button.Enabled = true;
                                initializeAlarms();
                                
                            }));
                           
                        }
                    }
                    i++;

                }
                Thread.Sleep(1);
            }
            
        }
       


    }
}
