using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CourseWork_S_and_D
{
    public partial class CoiseChangeTaskForm : Form
    {
        public CoiseChangeTaskForm()
        {
            InitializeComponent();
            this.HelpButtonClicked += new CancelEventHandler(HBClicked);
        }

        private void CoiseChangeTaskForm_Load(object sender, EventArgs e)
        {
            UpdateList(true);
            UpdateInfo(0);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo(listBox1.SelectedIndex);
        }

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

        private void repeatedCheckBox_CheckedChanged(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
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
        private void HBClicked(object sender, CancelEventArgs e){ 
            MessageBox.Show("Обравши завдання зі списку можна змінити його ім’я, дату та час виконання, стан завдання (активний чи неактивний), параметр повторюваності завдання. Для того, щоб зберегти зміни для задачі натисніть кнопку «Внести зміни».\n\n" +
                            "Для того, щоб видалити завдання зі списку оберіть його та натисніть «Видалити завдання».");
            e.Cancel = true;
        }
    }

}
