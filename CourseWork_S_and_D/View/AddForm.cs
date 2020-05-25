using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CourseWork_S_and_D
{
    /// <summary>
    /// A class that represents a form of adding 
    /// a new task and processing custom input.
    /// </summary>
    public partial class AddForm : Form
    {
        /// <summary>
        /// A class constructor that performs basic user interface initialization
        /// </summary>
        public AddForm()
        {
            InitializeComponent();
            ClearForm();
            this.HelpButtonClicked += new CancelEventHandler(Help_Btn_Clicked);
        }

        /// <summary>
        /// A method that handles clicking the Repeated CheckBox
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
        /// A method that handles clicking the add button.
        /// </summary>
        /// <param name="sender">The object that caused the event</param>
        /// <param name="e">Information and arguments for this event</param>
        private void Add_Task_Btn_Click(object sender, EventArgs e)
        {
            if(this.titleInputBox.Text!= String.Empty)
            {
                if (this.repeatedCheckBox.Checked)
                {
                    if(endDate.Value > startDate.Value)
                    {
                        Controller.controller.AddTask(this.titleInputBox.Text, this.startDate.Value, this.endDate.Value, Decimal.ToInt32(this.intervalNumericUpDown.Value));
                        MessageBox.Show("Завдання успішно додане", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Дата кінця не може передувати даті початку", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                else
                {
                    Controller.controller.AddTask(this.titleInputBox.Text, this.startDate.Value);
                    MessageBox.Show("Завдання успішно додане", "Повідомлення",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly);
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("Назва завдання не може бути порожньою", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        /// <summary>
        /// The method resets the form to the original state.
        /// </summary>
        private void ClearForm()
        {
            this.titleInputBox.Text = String.Empty;
            startDate.Value = DateTime.Now.AddHours(1);
            endDate.Value = DateTime.Now.AddHours(2);
            repeatedCheckBox.Checked = false;
            this.intervalNumericUpDown.Value = 60;
        }

        /// <summary>
        /// A method that handles clicking the help button.
        /// </summary>
        /// <param name="sender">The object that caused the event</param>
        /// <param name="e">The object to indicate the reasons for closing the form</param>
        private void Help_Btn_Clicked(object sender, CancelEventArgs e) 
        {
            MessageBox.Show("Для створення нового завдання:\n\n" +
                "Введіть назву нового завдання в полі «Назва».\n\n" + 
                "Натисніть прапорець біля пункту «Повторюване завдання», якщо нове завдання не є одноразовим.\n\n" + 
                "В полі «Дата виконання» введіть вручну час(години та хвилини) та введіть вручну або оберіть в календарі дату(число, місяць та рік) виконання завдання.\n\n" + 
                "Для того, щоб зберегти задачу натисніть кнопку «Додати завдання».");
            e.Cancel = true;
        }

    }
}
