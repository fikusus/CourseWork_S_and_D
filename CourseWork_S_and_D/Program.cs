using System;
using System.Threading;
using System.Windows.Forms;

namespace CourseWork_S_and_D
{
    static class Program
    {
        [STAThread]
        static void Main()
        {   
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
