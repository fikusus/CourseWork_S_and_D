using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CourseWork_S_and_D
{
    /// <summary>
    /// A class that informs the user about a planned task.
    /// </summary>
    class Notificator
    {/// <summary>
     /// The method works in a separate thread. 
     /// Displays a "bubble" notification about the task for the current time.
     /// </summary>
     /// <param name="icon">Image of the application in the tray</param>
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
