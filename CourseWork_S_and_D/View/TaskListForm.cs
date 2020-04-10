using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork_S_and_D
{
    public enum CalendarType
    {
        Today,
        Week
    }
    public partial class TaskListForm : Form
    {
        CalendarType type;
        public TaskListForm(CalendarType type)
        {
            InitializeComponent();
            this.type = type;
            switch (type)
            {
                case CalendarType.Today:
                    DateTime endOfDay = DateTime.Today.AddDays(1).AddTicks(-1);
                    this.Text = "Завдання на сьогодні";
                    titleLable.Text = "ЗАВДАННЯ НА СЬОГОДНІ";
                    this.taskList.Text = Controller.controller.TasksCalendarText(DateTime.Now, endOfDay);
                    break;
                case CalendarType.Week:
                    DateTime endOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + 8).AddTicks(-1);
                    this.Text = "Завдання на тиждень";
                    titleLable.Text = "ЗАВДАННЯ НА ТИЖДЕНЬ";
                    this.taskList.Text = Controller.controller.TasksCalendarText(DateTime.Now, endOfWeek);
                    break;
            }
        }

    }
}
