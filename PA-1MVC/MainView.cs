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
    public partial class MainView : Form
    {

        private MainInputhandler del;
        private Alarm selectedAlarm;
        
       
        /// <summary>
        /// Initializer for the view
        /// </summary>
        public MainView()
        {
            InitializeComponent();
        }

     
        /// <summary>
        /// Updates the view with the list of alarms and the current state of the program
        /// </summary>
        /// <param name="state">state of the program</param>
        /// <param name="Alarms">list of alarms</param>
        public void Update(State state, BindingList<Alarm> Alarms)
        {

            listbox.DataSource = null;
            listbox.DataSource = Alarms;
            listbox.DisplayMember = "ToString";
           
            if (state == State.ALERTING)
            {
                Invoke(new Action(() => {
                foreach (Alarm a in Alarms)
                {
                    if(a.status == Status.Alerting)
                    {
                            listbox.Enabled = false;
                            selectedAlarm = a;
                            alert_label.Text = "*" + a.sound + " sound*";
                        
                       
                    }
                }
                add_button.Enabled = false;
                edit_button.Enabled = false;
                snooze_button.Enabled = true;
                stop_button.Enabled = true;
                }));
            }
            else if(state == State.SELECTED)
            {
                listbox.Enabled = true;
                alert_label.Text = "";
                add_button.Enabled = true;
                edit_button.Enabled = true;
                snooze_button.Enabled = false;
                stop_button.Enabled = false;
            }
            else
            {

                listbox.Enabled = true;
                alert_label.Text = "";
                add_button.Enabled = true;
                edit_button.Enabled = false;
                snooze_button.Enabled = false;
                stop_button.Enabled = false;
            }

        }
        /// <summary>
        /// Initializes the maininput handeler delegate
        /// </summary>
        /// <param name="d">delegate from program</param>
        public void SetController(MainInputhandler d)
        {
            del = d;
        }
        
        /// <summary>
        /// occurs when the add button is clicked
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">argurments</param>
        private void add_button_Click(object sender, EventArgs e)
        {
            del(Actions.ADD, selectedAlarm);
        }
        /// <summary>
        /// occurs when the snooze button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void snooze_button_Click(object sender, EventArgs e)
        {
            del(Actions.SNOOZE, selectedAlarm);
        }
        /// <summary>
        /// occurs when the stop button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stop_button_Click(object sender, EventArgs e)
        {
            del(Actions.STOP, selectedAlarm);
        }

       
        /// <summary>
        /// occurs when the edit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void edit_button_Click(object sender, EventArgs e)
        {
            del(Actions.EDIT, selectedAlarm);
        }
        /// <summary>
        /// occurs when the selected value within the listbox changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAlarm = (Alarm)listbox.SelectedItem;
            edit_button.Enabled = true;
        }

        private void MainView_FormClosed(object s, FormClosedEventArgs e)
        {
            del(Actions.CLOSE, null);
        }

        
    }
}
