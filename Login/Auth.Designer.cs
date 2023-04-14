namespace cdo_den
{
    partial class Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.title_Main = new System.Windows.Forms.Label();
            this.title_Login = new System.Windows.Forms.Label();
            this.title_Password = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.title_TryCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox_Login);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(112, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 81);
            this.panel1.TabIndex = 0;
            // 
            // textBox_Login
            // 
            this.textBox_Login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Login.Location = new System.Drawing.Point(6, 8);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(242, 20);
            this.textBox_Login.TabIndex = 2;
            this.textBox_Login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Login_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox_Password);
            this.panel2.Location = new System.Drawing.Point(-1, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 40);
            this.panel2.TabIndex = 1;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Password.Location = new System.Drawing.Point(6, 10);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(242, 20);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Password_KeyDown);
            // 
            // title_Main
            // 
            this.title_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_Main.Location = new System.Drawing.Point(12, 9);
            this.title_Main.Name = "title_Main";
            this.title_Main.Size = new System.Drawing.Size(455, 48);
            this.title_Main.TabIndex = 1;
            this.title_Main.Text = "Авторизация";
            this.title_Main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title_Login
            // 
            this.title_Login.AutoSize = true;
            this.title_Login.Location = new System.Drawing.Point(116, 61);
            this.title_Login.Name = "title_Login";
            this.title_Login.Size = new System.Drawing.Size(38, 13);
            this.title_Login.TabIndex = 2;
            this.title_Login.Text = "Логин";
            // 
            // title_Password
            // 
            this.title_Password.AutoSize = true;
            this.title_Password.Location = new System.Drawing.Point(116, 102);
            this.title_Password.Name = "title_Password";
            this.title_Password.Size = new System.Drawing.Size(45, 13);
            this.title_Password.TabIndex = 3;
            this.title_Password.Text = "Пароль";
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Location = new System.Drawing.Point(202, 157);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 23);
            this.button_Login.TabIndex = 4;
            this.button_Login.Text = "Войти";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // title_TryCount
            // 
            this.title_TryCount.ForeColor = System.Drawing.Color.Gray;
            this.title_TryCount.Location = new System.Drawing.Point(3, 183);
            this.title_TryCount.Name = "title_TryCount";
            this.title_TryCount.Size = new System.Drawing.Size(473, 23);
            this.title_TryCount.TabIndex = 5;
            this.title_TryCount.Text = "label1";
            this.title_TryCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 227);
            this.Controls.Add(this.title_TryCount);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.title_Password);
            this.Controls.Add(this.title_Login);
            this.Controls.Add(this.title_Main);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЦДО | Авторизация";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label title_Main;
        private System.Windows.Forms.Label title_Login;
        private System.Windows.Forms.Label title_Password;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label title_TryCount;
    }
}

