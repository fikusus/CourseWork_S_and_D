﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork_S_and_D
{
    class Notificator
    {
        public void Run(object icon)
        {
            NotifyIcon NI = new NotifyIcon();
            NI.BalloonTipTitle = "Нагадування";
            NI.BalloonTipIcon = ToolTipIcon.Info;
            NI.Visible = true;
            NI.Icon = (Icon)icon;
;
            while (true)
            {
                Thread.Sleep(1000);
                DateTime current = DateTime.Now;
                DateTime past = current.AddMilliseconds(-1000);
                if((NI.BalloonTipText = Controller.controller.TasksCalendarText(past, current)) != String.Empty) 
                NI.ShowBalloonTip(1000);
            }
        }
    }
}