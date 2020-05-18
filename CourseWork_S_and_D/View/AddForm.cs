﻿using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CourseWork_S_and_D
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            ClearForm();
            this.HelpButtonClicked += new CancelEventHandler(Help_Btn_Clicked);
        }

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
        private void ClearForm()
        {
            this.titleInputBox.Text = String.Empty;
            startDate.Value = DateTime.Now.AddHours(1);
            endDate.Value = DateTime.Now.AddHours(2);
            repeatedCheckBox.Checked = false;
            this.intervalNumericUpDown.Value = 3600;
        }
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
