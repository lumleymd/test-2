using PA_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA_1MVC
{
    public partial class AddEditView : Form
    {

        private AddEditInputHandler del;
        
        private Alarm alarm;

        /// <summary>
        /// Initializes the view
        /// </summary>
        public AddEditView()
        {
            InitializeComponent();
        }

      
        /// <summary>
        /// If it there is no alarm set in it makes a new one and if there is already ana alrm it fills the form with the current alarms information
        /// </summary>
        /// <param name="a">current alarm</param>
        public void Open(Alarm a)
        {
            
            this.Visible = true;

            if (a != null)
            {
                alarm = a;
                
                combo_Box.SelectedItem = alarm.sound;
                if (alarm.status == Status.On)
                {
                    on_checkbox.Checked = true;
                }
                else
                {
                    on_checkbox.Checked = false;
                }
                snooze_amount.Value = alarm.snooze;
                dateTimePicker.Value = alarm.time;
            }
            else
            {
                combo_Box.SelectedItem = Sounds.Radar;
                
                on_checkbox.Checked = false;
                
                snooze_amount.Value = 3;
                dateTimePicker.Value = DateTime.Now;
                alarm = new Alarm(dateTimePicker.Value,Status.Off,Sounds.Radar, 3);
            }
            
        }
        /// <summary>
        /// Sets the delegate tot alk to the controller
        /// </summary>
        /// <param name="d"></param>
        public void SetController(AddEditInputHandler d)
        {
            del = d;
        }

       
        //occurs when the set button is clicked
        private void set_button_Click(object sender, EventArgs e)
        {
            alarm.snooze = (int)snooze_amount.Value;
            alarm.sound = (Sounds)combo_Box.SelectedItem;
            alarm.time = dateTimePicker.Value;
            if (on_checkbox.Checked)
            {
                alarm.status = Status.On;
            }
            else
            {
                alarm.status = Status.Off;
            }
            del(alarm);
            this.Visible = false;
        }
        /// <summary>
        /// occurs when the cancel button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancel_button_Click(object sender, EventArgs e)
        {
            del(null);
            this.Visible = false;
        }
        /// <summary>
        /// attempts to close the form nicely instead of killing it which harms the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEditView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }

      
    }
}
