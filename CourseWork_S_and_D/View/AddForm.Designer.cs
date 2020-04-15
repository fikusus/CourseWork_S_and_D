namespace CourseWork_S_and_D
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newTaskText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.repeatedTimeInputPanel = new System.Windows.Forms.Panel();
            this.intervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.endTimeTitle = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.repeatedCheckBox = new System.Windows.Forms.CheckBox();
            this.titleInputBox = new System.Windows.Forms.TextBox();
            this.timeInputPanel = new System.Windows.Forms.Panel();
            this.startTimeTitle = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.titleText = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.repeatedTimeInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.timeInputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // newTaskText
            // 
            this.newTaskText.AutoSize = true;
            this.newTaskText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(175)))), ((int)(((byte)(218)))));
            this.newTaskText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newTaskText.ForeColor = System.Drawing.SystemColors.Control;
            this.newTaskText.Location = new System.Drawing.Point(12, 23);
            this.newTaskText.Name = "newTaskText";
            this.newTaskText.Size = new System.Drawing.Size(278, 33);
            this.newTaskText.TabIndex = 2;
            this.newTaskText.Text = "НОВЕ ЗАВДАННЯ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(175)))), ((int)(((byte)(218)))));
            this.panel2.Controls.Add(this.newTaskText);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 75);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(208)))), ((int)(((byte)(239)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(146)))), ((int)(((byte)(188)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(175)))), ((int)(((byte)(218)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(69, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "Додати завдання";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // repeatedTimeInputPanel
            // 
            this.repeatedTimeInputPanel.Controls.Add(this.intervalNumericUpDown);
            this.repeatedTimeInputPanel.Controls.Add(this.label5);
            this.repeatedTimeInputPanel.Controls.Add(this.endTimeTitle);
            this.repeatedTimeInputPanel.Controls.Add(this.endDate);
            this.repeatedTimeInputPanel.Location = new System.Drawing.Point(0, 246);
            this.repeatedTimeInputPanel.Name = "repeatedTimeInputPanel";
            this.repeatedTimeInputPanel.Size = new System.Drawing.Size(299, 114);
            this.repeatedTimeInputPanel.TabIndex = 7;
            this.repeatedTimeInputPanel.Visible = false;
            // 
            // intervalNumericUpDown
            // 
            this.intervalNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intervalNumericUpDown.Location = new System.Drawing.Point(119, 74);
            this.intervalNumericUpDown.Maximum = new decimal(new int[] {
            604800,
            0,
            0,
            0});
            this.intervalNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intervalNumericUpDown.Name = "intervalNumericUpDown";
            this.intervalNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.intervalNumericUpDown.TabIndex = 8;
            this.intervalNumericUpDown.Value = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(25, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Інтервал";
            // 
            // endTimeTitle
            // 
            this.endTimeTitle.AutoSize = true;
            this.endTimeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endTimeTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.endTimeTitle.Location = new System.Drawing.Point(11, 5);
            this.endTimeTitle.Name = "endTimeTitle";
            this.endTimeTitle.Size = new System.Drawing.Size(204, 24);
            this.endTimeTitle.TabIndex = 0;
            this.endTimeTitle.Text = "Дата кінця виконання";
            // 
            // endDate
            // 
            this.endDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDate.Location = new System.Drawing.Point(69, 32);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(170, 26);
            this.endDate.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(108, 74);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            604800,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Інтервал";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(11, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Дата кінця виконання";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(69, 32);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(170, 26);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // repeatedCheckBox
            // 
            this.repeatedCheckBox.AutoSize = true;
            this.repeatedCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightCoral;
            this.repeatedCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.repeatedCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.repeatedCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repeatedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeatedCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.repeatedCheckBox.Location = new System.Drawing.Point(12, 124);
            this.repeatedCheckBox.Name = "repeatedCheckBox";
            this.repeatedCheckBox.Size = new System.Drawing.Size(240, 28);
            this.repeatedCheckBox.TabIndex = 3;
            this.repeatedCheckBox.Text = "Повторюване завдання";
            this.repeatedCheckBox.UseVisualStyleBackColor = true;
            this.repeatedCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // titleInputBox
            // 
            this.titleInputBox.BackColor = System.Drawing.Color.Snow;
            this.titleInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleInputBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.titleInputBox.Location = new System.Drawing.Point(82, 87);
            this.titleInputBox.Name = "titleInputBox";
            this.titleInputBox.Size = new System.Drawing.Size(200, 29);
            this.titleInputBox.TabIndex = 0;
            // 
            // timeInputPanel
            // 
            this.timeInputPanel.Controls.Add(this.startTimeTitle);
            this.timeInputPanel.Controls.Add(this.startDate);
            this.timeInputPanel.Location = new System.Drawing.Point(0, 171);
            this.timeInputPanel.Name = "timeInputPanel";
            this.timeInputPanel.Size = new System.Drawing.Size(299, 69);
            this.timeInputPanel.TabIndex = 6;
            // 
            // startTimeTitle
            // 
            this.startTimeTitle.AutoSize = true;
            this.startTimeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTimeTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startTimeTitle.Location = new System.Drawing.Point(11, 5);
            this.startTimeTitle.Name = "startTimeTitle";
            this.startTimeTitle.Size = new System.Drawing.Size(154, 24);
            this.startTimeTitle.TabIndex = 0;
            this.startTimeTitle.Text = "Дата виконання";
            // 
            // startDate
            // 
            this.startDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(69, 32);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(170, 26);
            this.startDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(11, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Дата виконання";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleText.Location = new System.Drawing.Point(12, 89);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(64, 24);
            this.titleText.TabIndex = 1;
            this.titleText.Text = "Назва";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(302, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.repeatedTimeInputPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.repeatedCheckBox);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.titleInputBox);
            this.Controls.Add(this.timeInputPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.Text = "Додавання завдання";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.repeatedTimeInputPanel.ResumeLayout(false);
            this.repeatedTimeInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.timeInputPanel.ResumeLayout(false);
            this.timeInputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label newTaskText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel repeatedTimeInputPanel;
        private System.Windows.Forms.NumericUpDown intervalNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label endTimeTitle;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox repeatedCheckBox;
        private System.Windows.Forms.TextBox titleInputBox;
        private System.Windows.Forms.Panel timeInputPanel;
        private System.Windows.Forms.Label startTimeTitle;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label titleText;
    }
}