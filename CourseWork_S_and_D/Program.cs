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
            MainForm mainForm = new MainForm();
            Thread notify = new Thread(new Notificator().Run);
            notify.IsBackground = true;
            notify.Start(mainForm.Icon);
            Application.Run(mainForm);
            notify.Abort();
        }     
    }
}
