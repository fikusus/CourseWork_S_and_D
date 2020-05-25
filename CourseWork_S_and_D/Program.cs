using System;
using System.Threading;
using System.Windows.Forms;

namespace CourseWork_S_and_D
{/// <summary>
/// The main class of the program. 
/// Contains a method to run all the functionality.
/// </summary>
    static class Program
    {
        /// <summary>
        /// The main method of the program. 
        /// Responsible for the primary initialization of all components. 
        /// Launches notification and graphical interfaces.
        /// </summary>
        static void Main()
        {   
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mainForm = new MainForm();
            Thread notify = new Thread(new Notificator().Run);
            notify.IsBackground = true;
            notify.Start(mainForm.Icon);
            Application.Run(mainForm);
            notify.Abort();
        }     
    }
}
