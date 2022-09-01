using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA_1
{
    public partial class Add_Edit : Form
    {
        int alarmNum;
        
        Main main;
        /// <summary>
        /// initializes the form with the current alarms info if it is editing an alarm
        /// </summary>
        /// <param name="num"></param>
        /// <param name="m"></param>
        public Add_Edit(int num, Main m)
        {
            InitializeComponent();
            alarmNum = num;
           
            main = m;
            if(num != -1)
            {
                time_input.Value = main.ar[alarmNum].time;

                if (main.ar[alarmNum].status == "On")
                {
                    status_check.Checked = true;
                }
            }
            
            
            
        }
        /// <summary>
        /// makes a new or edits the old one if the user hits the set button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void set_button_Click(object sender, EventArgs e)
        {
            DateTime time = time_input.Value;
            bool on = status_check.Checked;

            string status = "On";
            if (!on)
            {
                status = "Off";
            }
            if (alarmNum != -1)
            {

                
              
                //here we would update the current alarm
                main.editAlarm(alarmNum, time, status);
               

            }
            else
            {
                
                
                main.addAlarm(time, status);
                
            }

            this.Close();

        }
        /// <summary>
        /// closes the form if the user hits cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancel_button_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        
    }
}
