﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.HelpButtonClicked += new CancelEventHandler(HBClicked);
        }
        private void HBClicked(object sender, CancelEventArgs e) //сам обработчик
        {
            MessageBox.Show("'Учиться, учиться и еще раз учиться!'\n В.И. Ленин"); //действия, которые будут выполняться при щелчке по HelpButton
            e.Cancel = true;
        }
    }
}