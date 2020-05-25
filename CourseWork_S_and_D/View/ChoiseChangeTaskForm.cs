using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CourseWork_S_and_D
{
    /// <summary>
    /// A class that represents a form of changing 
    /// already created tasks and processing user input.
    /// </summary>
    public partial class ChoiseChangeTaskForm : Form
    {
        /// <summary>
        /// A class constructor that performs basic user interface initialization
        /// </summary>
        public ChoiseChangeTaskForm()
        {
            InitializeComponent();
            this.HelpButtonClicked += new CancelEventHandler(Help_Btn_Clicked);
        }

        /// <summary>
        /// A method that updates the form the first time it is loaded.
        /// </summary>
        /// <param name="sender">The object that caused the event</param>
        /// <param name="e">Information and arguments for this event</param>
        private void ChoiseChangeTaskForm_Load(object sender, EventArgs e)
        {
            UpdateList(true);
            UpdateInfo(0);
        }

        /// <summary>
        /// Method processing the selection of a new element from the list.
        /// </summary>
        /// <param name="sender">The object that caused the event</param>
        /// <param name="e">Information and arguments for this event</param>
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo(listBox1.SelectedIndex);
        }

        /// <summary>
        /// A method that substitutes information about a selected task in form fields.
        /// </summary>
        /// <param name="index">Index of the selected task</param>
        private void UpdateInfo(int index)
        {
            Task temp = Controller.controller.GetTaskFromTaskList(index);
            this.titleInputBox.Text = temp.Title;
            this.repeatedCheckBox.Checked = temp.IsRepeated;
            this.activeCheckBox.Checked = temp.IsActive;
            if (temp.IsRepeated)
            {
                this.startDate.Value = temp.GetStartTime();
                this.endDate.Value = temp.GetEndTime();
                this.intervalNumericUpDown.Value = temp.GetRepeatInterval();
            }
            else
            {
                this.startDate.Value = temp.GetTime();
            }
        }

        /// <summary>
        /// Method updating the list of all tasks
        /// </summary>
        /// <param name="setFirst">Selection cursor position key</param>
        private void UpdateList(bool setFirst)
        {
            if (Controller.controller.GetCountOfTasks() == 0)
            {
                this.Close();
            }
            else
            {
                int oldIndex = listBox1.SelectedIndex;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(Controller.controller.GetTaskListInfo());
                listBox1.SelectedIndex = (setFirst) ? 0 : oldIndex;
            }
        }

        /// <summary>
        /// A method that handles clicking thes Repeated CheckBox
        /// </summary>
        /// <param name="sender">The object that caused the event</param>
        /// <param name="e">Information and arguments for this event</param>
        private void IsRepeated_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.repeatedTimeInputPanel.Visible = this.repeatedCheckBox.Checked;
            if (this.repeatedCheckBox.Checked)
            {
                this.startTimeTitle.Text = "Дата початку виконання";
            }
            else
            {
                this.startTimeTitle.Text = "Дата виконання";
            }
        }

        /// <summary>
        /// A method that handles clicking the remove button.
        /// </summary>
        /// <param name="sender">The object that caused the event</param>
        /// <param name="e">Information and arguments for this event</param>
        private void Remove_Btn_Click(object sender, EventArgs e)
        {
            if (Controller.controller.RemoveTaskFromTaskList(listBox1.SelectedIndex))
            {
                MessageBox.Show("Завдання успішно видалено", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                MessageBox.Show("Виникла помилка при видаленні", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            UpdateList(true);
        }

        /// <summary>
        /// A method that handles clicking the change button.
        /// </summary>
        /// <param name="sender">The object that caused the event</param>
        /// <param name="e">Information and arguments for this event</param>
        private void Change_Btn_Click(object sender, EventArgs e)
        {
            if (this.titleInputBox.Text != String.Empty)
            {
                if (this.repeatedCheckBox.Checked)
                {
                    if (endDate.Value > startDate.Value)
                    {
                        Controller.controller.ChangeDateInTaskList(this.listBox1.SelectedIndex, titleInputBox.Text, this.startDate.Value, this.endDate.Value, Decimal.ToInt32(this.intervalNumericUpDown.Value), activeCheckBox.Checked);
                        MessageBox.Show("Завдання успішно змінено", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                    else
                    {
                        MessageBox.Show("Дата кінця не може передувати даті початку", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                else
                {
                    Controller.controller.ChangeDateInTaskList(this.listBox1.SelectedIndex, titleInputBox.Text, this.startDate.Value, activeCheckBox.Checked);
                    MessageBox.Show("Завдання успішно змінено", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            else
            {
                MessageBox.Show("Назва завдання не може бути порожньою", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            UpdateList(false);
        }

        /// <summary>
        /// A method that handles clicking the help button.
        /// </summary>
        /// <param name="sender">The object that caused the event</param>
        /// <param name="e">The object to indicate the reasons for closing the form</param>
        private void Help_Btn_Clicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Обравши завдання зі списку можна змінити його ім’я, дату та час виконання, стан завдання (активний чи неактивний), параметр повторюваності завдання. Для того, щоб зберегти зміни для задачі натисніть кнопку «Внести зміни».\n\n" +
                            "Для того, щоб видалити завдання зі списку оберіть його та натисніть «Видалити завдання».");
            e.Cancel = true;
        }
    }

}
