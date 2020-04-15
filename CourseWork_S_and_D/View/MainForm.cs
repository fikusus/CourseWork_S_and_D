using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CourseWork_S_and_D
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.HelpButtonClicked += new CancelEventHandler(HBClicked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaskListForm taskListForm = new TaskListForm(CalendarType.Today);
            taskListForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TaskListForm taskListForm = new TaskListForm(CalendarType.Week);
            taskListForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Controller.controller.GetCountOfTasks() == 0)
            {
                MessageBox.Show("Спочатку додайте хоча б одне завдання", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                CoiseChangeTaskForm coiseChangeTaskForm = new CoiseChangeTaskForm();
                coiseChangeTaskForm.ShowDialog();
            }
        }

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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
