using System;
using System.ComponentModel;
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
        public TaskListForm(CalendarType type)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            switch (type)
            {
                case CalendarType.Today:
                    ShowTodayTask();
                    break;
                case CalendarType.Week:
                    ShowWeekTask();
                    break;
            }
        }

        public void ShowTodayTask()
        {
            this.Text = "Завдання на сьогодні";
            titleLable.Text = "ЗАВДАННЯ НА СЬОГОДНІ";
            this.taskList.Text = Controller.controller.TasksCalendarText(DateTime.Now, DateTime.Today.AddDays(1).AddTicks(-1));
        }

        public void ShowWeekTask()
        {
            this.Text = "Завдання на тиждень";
            titleLable.Text = "ЗАВДАННЯ НА ТИЖДЕНЬ";
            this.taskList.Text = Controller.controller.TasksCalendarText(DateTime.Now, DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + 8).AddTicks(-1));
        }

        protected override void OnShown(EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }
    }
}
