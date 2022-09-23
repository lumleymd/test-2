using PA_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA_1MVC
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainView main = new MainView();
            MainObserver mainobserver = new MainObserver(main.Update);

            AddEditView addEdit = new AddEditView();
            AddEditObserver addeditobserver = new AddEditObserver(addEdit.Open);

            Controller controller = new Controller(addeditobserver,mainobserver);
            main.SetController(controller.ButtonClick);
            addEdit.SetController(controller.AddViewButtonClick);

            Application.Run(main);
        }
    }

    public delegate void MainObserver(State state, BindingList<Alarm> Alarms);
    public delegate void MainInputhandler(Actions action, Alarm alarm);
    public delegate void AddEditInputHandler(Alarm alarm);
    public delegate void AddEditObserver(Alarm alarm);

}
