using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CourseWork_S_and_D
{
    /// <summary>
    /// A class that represents the main menu of the application and provides a choice of further depending on the user's actions.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// A class constructor that performs basic user interface initialization
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.HelpButtonClicked += new CancelEventHandler(HBClicked);
        }

        /// <summary>
        /// A method that handles clicking the add button.
        /// </summary>
        /// <param name="sender">The object that caused the event</param>
        /// <param name="e">Information and arguments for this event</param>
        private void AddForm_OpenBtn_Click(object sender, EventArgs e)
        {
            new AddForm().ShowDialog();
        }

        /// <summary>
        /// A method that handles clicking the tasks for today button.
        /// </summary>
        /// <param name="sender">The object that caused the event</param>
        /// <param name="e">Information and arguments for this event</param>
        private void TaskForToday_OpenBtn_Click(object sender, EventArgs e)
        {
            new TaskListForm(CalendarType.Today).ShowDialog(); ;
        }

        /// <summary>
        /// A method that handles clicking the tasks for week button.
        /// </summary>
        /// <param name="sender">The object that caused the event</param>
        /// <param name="e">Information and arguments for this event</param>
        private void TaskForWeek_OpenBtn_Click(object sender, EventArgs e)
        {
            new TaskListForm(CalendarType.Week).ShowDialog();
        }

        /// <summary>
        /// A method that handles clicking the change task button.
        /// </summary>
        /// <param name="sender">The object that caused the event</param>
        /// <param name="e">Information and arguments for this event</param>
        private void ChangeTask_OpenBtn_Click(object sender, EventArgs e)
        {
            if(Controller.controller.GetCountOfTasks() == 0)
            {
                MessageBox.Show("Спочатку додайте хоча б одне завдання", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                new ChoiseChangeTaskForm().ShowDialog(); 
            }
        }

        /// <summary>
        /// A method that handles clicking the help button.
        /// </summary>
        /// <param name="sender">The object that caused the event</param>
        /// <param name="e">The object to indicate the reasons for closing the form</param>
        private void HBClicked(object sender, CancelEventArgs e) 
        {
            MessageBox.Show("Доброго дня!\n" +
                "Вас вітає програма для організації та систематизації ваших завдань «Task Manager»\n\n" +
                "Щоб створити нове задання оберіть у головному меню «Додати завдання»\n\n" +
                "Для того, щоб переглянути поточні завдання на сьогодні оберіть у головному меню «Завдання на сьогодні»\n\n" +
                "Для того, щоб переглянути завдання до кінця тижня оберіть у головному меню «Завдання до кінця тижня»\n\n" +
                "Поточні завдання, тобто завдання призначені на виконання з поточного моменту (тобто поточного часу на циферблаті) до кінця дня, з’являться у вигляді списку. Буде вказано ім’я завдання, дата та час його виконання.\n" +
                "Якщо завдання на сьогодні відсутні, то список буде порожнім\n\n" +
                "Для того, щоб внести зміні або видалити завдання зі списку оберіть у головному меню «Змінити/видалити завдання»"); 
            e.Cancel = true;
        }
    }
}
