namespace CourseWork_S_and_D
{
    partial class ChoiseChangeTaskForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.repeatedTimeInputPanel = new System.Windows.Forms.Panel();
            this.intervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.endTimeTitle = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.repeatedCheckBox = new System.Windows.Forms.CheckBox();
            this.titleText = new System.Windows.Forms.Label();
            this.titleInputBox = new System.Windows.Forms.TextBox();
            this.timeInputPanel = new System.Windows.Forms.Panel();
            this.startTimeTitle = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.repeatedTimeInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).BeginInit();
            this.timeInputPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(175)))), ((int)(((byte)(218)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(12, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(447, 316);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(208)))), ((int)(((byte)(239)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(146)))), ((int)(((byte)(188)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(175)))), ((int)(((byte)(218)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(630, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 61);
            this.button1.TabIndex = 14;
            this.button1.Text = "Внести \r\nзміни";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Change_Btn_Click);
            // 
            // repeatedTimeInputPanel
            // 
            this.repeatedTimeInputPanel.Controls.Add(this.intervalNumericUpDown);
            this.repeatedTimeInputPanel.Controls.Add(this.label5);
            this.repeatedTimeInputPanel.Controls.Add(this.endTimeTitle);
            this.repeatedTimeInputPanel.Controls.Add(this.endDate);
            this.repeatedTimeInputPanel.Location = new System.Drawing.Point(473, 204);
            this.repeatedTimeInputPanel.Name = "repeatedTimeInputPanel";
            this.repeatedTimeInputPanel.Size = new System.Drawing.Size(299, 114);
            this.repeatedTimeInputPanel.TabIndex = 13;
            this.repeatedTimeInputPanel.Visible = false;
            // 
            // intervalNumericUpDown
            // 
            this.intervalNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intervalNumericUpDown.Location = new System.Drawing.Point(106, 73);
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
            this.label5.Location = new System.Drawing.Point(12, 73);
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
            // repeatedCheckBox
            // 
            this.repeatedCheckBox.AutoSize = true;
            this.repeatedCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightCoral;
            this.repeatedCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.repeatedCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.repeatedCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repeatedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeatedCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.repeatedCheckBox.Location = new System.Drawing.Point(485, 69);
            this.repeatedCheckBox.Name = "repeatedCheckBox";
            this.repeatedCheckBox.Size = new System.Drawing.Size(216, 28);
            this.repeatedCheckBox.TabIndex = 11;
            this.repeatedCheckBox.Text = "Повторювана задача";
            this.repeatedCheckBox.UseVisualStyleBackColor = true;
            this.repeatedCheckBox.CheckedChanged += new System.EventHandler(this.IsRepeated_CheckBox_CheckedChanged);
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleText.Location = new System.Drawing.Point(485, 34);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(64, 24);
            this.titleText.TabIndex = 10;
            this.titleText.Text = "Назва";
            // 
            // titleInputBox
            // 
            this.titleInputBox.BackColor = System.Drawing.Color.Snow;
            this.titleInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleInputBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.titleInputBox.Location = new System.Drawing.Point(555, 33);
            this.titleInputBox.Name = "titleInputBox";
            this.titleInputBox.Size = new System.Drawing.Size(200, 29);
            this.titleInputBox.TabIndex = 9;
            // 
            // timeInputPanel
            // 
            this.timeInputPanel.Controls.Add(this.startTimeTitle);
            this.timeInputPanel.Controls.Add(this.startDate);
            this.timeInputPanel.Location = new System.Drawing.Point(473, 129);
            this.timeInputPanel.Name = "timeInputPanel";
            this.timeInputPanel.Size = new System.Drawing.Size(299, 69);
            this.timeInputPanel.TabIndex = 12;
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
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightCoral;
            this.activeCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.activeCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.activeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activeCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.activeCheckBox.Location = new System.Drawing.Point(485, 99);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(168, 28);
            this.activeCheckBox.TabIndex = 15;
            this.activeCheckBox.Text = "Активна задача";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(208)))), ((int)(((byte)(239)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(146)))), ((int)(((byte)(188)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(175)))), ((int)(((byte)(218)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(473, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 61);
            this.button2.TabIndex = 16;
            this.button2.Text = "Видалити завдання";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Remove_Btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(175)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 61);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Зміна параметрів завдання";
            // 
            // CoiseChangeTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(791, 409);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.repeatedTimeInputPanel);
            this.Controls.Add(this.repeatedCheckBox);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.titleInputBox);
            this.Controls.Add(this.timeInputPanel);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CoiseChangeTaskForm";
            this.Text = "Зміна параметрів";
            this.repeatedTimeInputPanel.ResumeLayout(false);
            this.repeatedTimeInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).EndInit();
            this.timeInputPanel.ResumeLayout(false);
            this.timeInputPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel repeatedTimeInputPanel;
        private System.Windows.Forms.NumericUpDown intervalNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label endTimeTitle;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.CheckBox repeatedCheckBox;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.TextBox titleInputBox;
        private System.Windows.Forms.Panel timeInputPanel;
        private System.Windows.Forms.Label startTimeTitle;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}