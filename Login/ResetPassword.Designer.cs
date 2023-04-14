namespace cdo_den
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Pass2 = new System.Windows.Forms.TextBox();
            this.textBox_Pass1 = new System.Windows.Forms.TextBox();
            this.title_Main = new System.Windows.Forms.Label();
            this.button_TryReset = new System.Windows.Forms.Button();
            this.title_Pass1 = new System.Windows.Forms.Label();
            this.title_Pass2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.title_Login = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox_Pass2);
            this.panel1.Controls.Add(this.textBox_Pass1);
            this.panel1.Location = new System.Drawing.Point(149, 126);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 93);
            this.panel1.TabIndex = 1;
            // 
            // textBox_Pass2
            // 
            this.textBox_Pass2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Pass2.Location = new System.Drawing.Point(8, 60);
            this.textBox_Pass2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Pass2.Name = "textBox_Pass2";
            this.textBox_Pass2.Size = new System.Drawing.Size(321, 22);
            this.textBox_Pass2.TabIndex = 3;
            this.textBox_Pass2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Pass2_KeyDown);
            // 
            // textBox_Pass1
            // 
            this.textBox_Pass1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Pass1.Location = new System.Drawing.Point(8, 10);
            this.textBox_Pass1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Pass1.Name = "textBox_Pass1";
            this.textBox_Pass1.Size = new System.Drawing.Size(321, 22);
            this.textBox_Pass1.TabIndex = 2;
            this.textBox_Pass1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Pass1_KeyDown);
            // 
            // title_Main
            // 
            this.title_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_Main.Location = new System.Drawing.Point(16, 7);
            this.title_Main.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_Main.Name = "title_Main";
            this.title_Main.Size = new System.Drawing.Size(607, 59);
            this.title_Main.TabIndex = 2;
            this.title_Main.Text = "Сброс пароля";
            this.title_Main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title_Main.Click += new System.EventHandler(this.title_Main_Click);
            // 
            // button_TryReset
            // 
            this.button_TryReset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_TryReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.button_TryReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TryReset.Location = new System.Drawing.Point(245, 230);
            this.button_TryReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_TryReset.Name = "button_TryReset";
            this.button_TryReset.Size = new System.Drawing.Size(147, 28);
            this.button_TryReset.TabIndex = 3;
            this.button_TryReset.Text = "Подтвердить";
            this.button_TryReset.UseVisualStyleBackColor = false;
            this.button_TryReset.Click += new System.EventHandler(this.button_TryReset_Click);
            // 
            // title_Pass1
            // 
            this.title_Pass1.AutoSize = true;
            this.title_Pass1.Location = new System.Drawing.Point(155, 114);
            this.title_Pass1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_Pass1.Name = "title_Pass1";
            this.title_Pass1.Size = new System.Drawing.Size(157, 16);
            this.title_Pass1.TabIndex = 4;
            this.title_Pass1.Text = "Введите новый пароль";
            // 
            // title_Pass2
            // 
            this.title_Pass2.AutoSize = true;
            this.title_Pass2.Location = new System.Drawing.Point(155, 165);
            this.title_Pass2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_Pass2.Name = "title_Pass2";
            this.title_Pass2.Size = new System.Drawing.Size(129, 16);
            this.title_Pass2.TabIndex = 5;
            this.title_Pass2.Text = "Повторите пароль";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox_Login);
            this.panel2.Location = new System.Drawing.Point(149, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 51);
            this.panel2.TabIndex = 6;
            // 
            // textBox_Login
            // 
            this.textBox_Login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Login.Location = new System.Drawing.Point(8, 9);
            this.textBox_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(321, 22);
            this.textBox_Login.TabIndex = 4;
            this.textBox_Login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Login_KeyDown);
            // 
            // title_Login
            // 
            this.title_Login.AutoSize = true;
            this.title_Login.Location = new System.Drawing.Point(155, 68);
            this.title_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_Login.Name = "title_Login";
            this.title_Login.Size = new System.Drawing.Size(104, 16);
            this.title_Login.TabIndex = 7;
            this.title_Login.Text = "Введите логин";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(149, 79);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 51);
            this.panel3.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(8, 9);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Login_KeyDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Location = new System.Drawing.Point(149, 126);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 93);
            this.panel4.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Location = new System.Drawing.Point(8, 60);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(321, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Pass2_KeyDown);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.Location = new System.Drawing.Point(8, 10);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(321, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Pass1_KeyDown);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(639, 279);
            this.Controls.Add(this.title_Login);
            this.Controls.Add(this.title_Pass2);
            this.Controls.Add(this.title_Pass1);
            this.Controls.Add(this.button_TryReset);
            this.Controls.Add(this.title_Main);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЦДО | Сброс пароля";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Pass1;
        private System.Windows.Forms.TextBox textBox_Pass2;
        private System.Windows.Forms.Label title_Main;
        private System.Windows.Forms.Button button_TryReset;
        private System.Windows.Forms.Label title_Pass1;
        private System.Windows.Forms.Label title_Pass2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Label title_Login;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}