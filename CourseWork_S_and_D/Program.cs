using CourseWork_S_and_D.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork_S_and_D
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {   
            Controller.controller.GetType();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Notificator notificator = new Notificator();
            MainForm mainForm = new MainForm();
            Thread notify = new Thread(notificator.Run);
            notify.IsBackground = true;
            notify.Start(mainForm.Icon);
            Application.Run(new MainForm());
            notify.Abort();
        }     
    }
}
