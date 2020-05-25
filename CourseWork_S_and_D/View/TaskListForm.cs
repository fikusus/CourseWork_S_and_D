using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CourseWork_S_and_D
{
    /// <summary>
    /// Enumeration to determine the type of task list displayed.
    /// </summary>
    public enum CalendarType
    {
        Today,
        Week
    }

    /// <summary>
    /// A class that presents a list of tasks for a specific period of time (day / week) according to user needs.
    /// </summary>
    public partial class TaskListForm : Form
    {
        /// <summary>
        /// A class constructor that performs basic user interface initialization and the type of tasks displayed
        /// </summary>
        /// <param name="type"></param>
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

        /// <summary>
        /// The method displays all tasks until the end of the day.
        /// </summary>
        public void ShowTodayTask()
        {
            this.Text = "Завдання на сьогодні";
            titleLable.Text = "ЗАВДАННЯ НА СЬОГОДНІ";
            this.taskList.Text = Controller.controller.TasksCalendarText(DateTime.Now, DateTime.Today.AddDays(1).AddTicks(-1));
        }

        /// <summary>
        /// The method displays all tasks until the end of the week.
        /// </summary>
        public void ShowWeekTask()
        {
            this.Text = "Завдання на тиждень";
            titleLable.Text = "ЗАВДАННЯ НА ТИЖДЕНЬ";
            this.taskList.Text = Controller.controller.TasksCalendarText(DateTime.Now, DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + 8).AddTicks(-1));
        }

        /// <summary>
        /// A method that processes actions after a form is displayed.
        /// </summary>
        /// <param name="e">Information and arguments for this event</param>
        protected override void OnShown(EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }
    }
}
