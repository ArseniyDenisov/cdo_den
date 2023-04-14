namespace cdo_den
{
    partial class AddEditContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditContract));
            this.comboBox_EduProgram = new System.Windows.Forms.ComboBox();
            this.label_EduProgram = new System.Windows.Forms.Label();
            this.label_Student_FullName = new System.Windows.Forms.Label();
            this.label_Payer_FullName = new System.Windows.Forms.Label();
            this.label_Payer_Address = new System.Windows.Forms.Label();
            this.textBox_Student_FullName = new System.Windows.Forms.TextBox();
            this.textBox_Payer_FullName = new System.Windows.Forms.TextBox();
            this.textBox_Payer_Address = new System.Windows.Forms.TextBox();
            this.checkBox_Paid = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_StartDate = new System.Windows.Forms.Label();
            this.label_EndDate = new System.Windows.Forms.Label();
            this.label_EndDate_Value = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_EduProgram
            // 
            this.comboBox_EduProgram.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_EduProgram.FormattingEnabled = true;
            this.comboBox_EduProgram.Location = new System.Drawing.Point(171, 7);
            this.comboBox_EduProgram.Name = "comboBox_EduProgram";
            this.comboBox_EduProgram.Size = new System.Drawing.Size(316, 21);
            this.comboBox_EduProgram.TabIndex = 0;
            this.comboBox_EduProgram.SelectedIndexChanged += new System.EventHandler(this.comboBox_EduProgram_SelectedIndexChanged);
            // 
            // label_EduProgram
            // 
            this.label_EduProgram.AutoSize = true;
            this.label_EduProgram.Location = new System.Drawing.Point(8, 12);
            this.label_EduProgram.Name = "label_EduProgram";
            this.label_EduProgram.Size = new System.Drawing.Size(161, 13);
            this.label_EduProgram.TabIndex = 1;
            this.label_EduProgram.Text = "Образовательная программа:";
            // 
            // label_Student_FullName
            // 
            this.label_Student_FullName.AutoSize = true;
            this.label_Student_FullName.Location = new System.Drawing.Point(8, 37);
            this.label_Student_FullName.Name = "label_Student_FullName";
            this.label_Student_FullName.Size = new System.Drawing.Size(99, 13);
            this.label_Student_FullName.TabIndex = 2;
            this.label_Student_FullName.Text = "ФИО обучаемого:";
            // 
            // label_Payer_FullName
            // 
            this.label_Payer_FullName.AutoSize = true;
            this.label_Payer_FullName.Location = new System.Drawing.Point(8, 62);
            this.label_Payer_FullName.Name = "label_Payer_FullName";
            this.label_Payer_FullName.Size = new System.Drawing.Size(108, 13);
            this.label_Payer_FullName.TabIndex = 3;
            this.label_Payer_FullName.Text = "ФИО плательщика:";
            // 
            // label_Payer_Address
            // 
            this.label_Payer_Address.AutoSize = true;
            this.label_Payer_Address.Location = new System.Drawing.Point(8, 87);
            this.label_Payer_Address.Name = "label_Payer_Address";
            this.label_Payer_Address.Size = new System.Drawing.Size(112, 13);
            this.label_Payer_Address.TabIndex = 4;
            this.label_Payer_Address.Text = "Адрес плательщика:";
            // 
            // textBox_Student_FullName
            // 
            this.textBox_Student_FullName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Student_FullName.Location = new System.Drawing.Point(171, 32);
            this.textBox_Student_FullName.Name = "textBox_Student_FullName";
            this.textBox_Student_FullName.Size = new System.Drawing.Size(316, 20);
            this.textBox_Student_FullName.TabIndex = 5;
            // 
            // textBox_Payer_FullName
            // 
            this.textBox_Payer_FullName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Payer_FullName.Location = new System.Drawing.Point(171, 57);
            this.textBox_Payer_FullName.Name = "textBox_Payer_FullName";
            this.textBox_Payer_FullName.Size = new System.Drawing.Size(316, 20);
            this.textBox_Payer_FullName.TabIndex = 6;
            // 
            // textBox_Payer_Address
            // 
            this.textBox_Payer_Address.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Payer_Address.Location = new System.Drawing.Point(171, 82);
            this.textBox_Payer_Address.Name = "textBox_Payer_Address";
            this.textBox_Payer_Address.Size = new System.Drawing.Size(316, 20);
            this.textBox_Payer_Address.TabIndex = 7;
            // 
            // checkBox_Paid
            // 
            this.checkBox_Paid.AutoSize = true;
            this.checkBox_Paid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox_Paid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Paid.Location = new System.Drawing.Point(11, 162);
            this.checkBox_Paid.Name = "checkBox_Paid";
            this.checkBox_Paid.Size = new System.Drawing.Size(66, 17);
            this.checkBox_Paid.TabIndex = 8;
            this.checkBox_Paid.Text = "Оплачен";
            this.checkBox_Paid.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.LightGray;
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label_StartDate
            // 
            this.label_StartDate.AutoSize = true;
            this.label_StartDate.Location = new System.Drawing.Point(8, 112);
            this.label_StartDate.Name = "label_StartDate";
            this.label_StartDate.Size = new System.Drawing.Size(123, 13);
            this.label_StartDate.TabIndex = 10;
            this.label_StartDate.Text = "Дата начала обучения:";
            // 
            // label_EndDate
            // 
            this.label_EndDate.AutoSize = true;
            this.label_EndDate.Location = new System.Drawing.Point(8, 137);
            this.label_EndDate.Name = "label_EndDate";
            this.label_EndDate.Size = new System.Drawing.Size(141, 13);
            this.label_EndDate.TabIndex = 11;
            this.label_EndDate.Text = "Дата окончания обучения:";
            // 
            // label_EndDate_Value
            // 
            this.label_EndDate_Value.AutoSize = true;
            this.label_EndDate_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_EndDate_Value.Location = new System.Drawing.Point(169, 137);
            this.label_EndDate_Value.Name = "label_EndDate_Value";
            this.label_EndDate_Value.Size = new System.Drawing.Size(11, 13);
            this.label_EndDate_Value.TabIndex = 12;
            this.label_EndDate_Value.Text = " ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_EduProgram);
            this.panel1.Controls.Add(this.label_EndDate_Value);
            this.panel1.Controls.Add(this.comboBox_EduProgram);
            this.panel1.Controls.Add(this.label_EndDate);
            this.panel1.Controls.Add(this.label_Student_FullName);
            this.panel1.Controls.Add(this.label_StartDate);
            this.panel1.Controls.Add(this.label_Payer_FullName);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label_Payer_Address);
            this.panel1.Controls.Add(this.checkBox_Paid);
            this.panel1.Controls.Add(this.textBox_Student_FullName);
            this.panel1.Controls.Add(this.textBox_Payer_Address);
            this.panel1.Controls.Add(this.textBox_Payer_FullName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 193);
            this.panel1.TabIndex = 13;
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Location = new System.Drawing.Point(213, 211);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(90, 23);
            this.button_Save.TabIndex = 14;
            this.button_Save.Text = "Оформить";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // AddEditContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 240);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddEditContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЦДО | Оформление договора";
            this.Load += new System.EventHandler(this.AddEditContract_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_EduProgram;
        private System.Windows.Forms.Label label_EduProgram;
        private System.Windows.Forms.Label label_Student_FullName;
        private System.Windows.Forms.Label label_Payer_FullName;
        private System.Windows.Forms.Label label_Payer_Address;
        private System.Windows.Forms.TextBox textBox_Student_FullName;
        private System.Windows.Forms.TextBox textBox_Payer_FullName;
        private System.Windows.Forms.TextBox textBox_Payer_Address;
        private System.Windows.Forms.CheckBox checkBox_Paid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_StartDate;
        private System.Windows.Forms.Label label_EndDate;
        private System.Windows.Forms.Label label_EndDate_Value;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Save;
    }
}