using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CourseWork_S_and_D
{
    class Notificator
    {
        public void Run(object icon)
        {
            NotifyIcon notyfyIcon = new NotifyIcon();
            notyfyIcon.BalloonTipTitle = "Нагадування";
            notyfyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notyfyIcon.Visible = true;
            notyfyIcon.Icon = (Icon)icon;
            while (true)
            {
                Thread.Sleep(10000);
                if((notyfyIcon.BalloonTipText = Controller.controller.TasksCalendarText(DateTime.Now, DateTime.Now.AddMilliseconds(-10000))) != "Завдання відсутні") 
                notyfyIcon.ShowBalloonTip(1000);
            }
        }
    }
}
