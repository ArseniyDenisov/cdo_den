namespace cdo_den
{
    partial class CorporateMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorporateMenu));
            this.title_FullName = new System.Windows.Forms.Label();
            this.button_AccountExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Contract = new System.Windows.Forms.Button();
            this.button_Individual = new System.Windows.Forms.Button();
            this.button_EducationalProgram = new System.Windows.Forms.Button();
            this.title_Catalog = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_FullName
            // 
            this.title_FullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title_FullName.Location = new System.Drawing.Point(182, 1);
            this.title_FullName.Name = "title_FullName";
            this.title_FullName.Size = new System.Drawing.Size(227, 21);
            this.title_FullName.TabIndex = 0;
            this.title_FullName.Text = "title_FullName";
            this.title_FullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_AccountExit
            // 
            this.button_AccountExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_AccountExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.button_AccountExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AccountExit.Location = new System.Drawing.Point(408, 1);
            this.button_AccountExit.Name = "button_AccountExit";
            this.button_AccountExit.Size = new System.Drawing.Size(75, 21);
            this.button_AccountExit.TabIndex = 1;
            this.button_AccountExit.Text = "Выход";
            this.button_AccountExit.UseVisualStyleBackColor = false;
            this.button_AccountExit.Click += new System.EventHandler(this.button_AccountExit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_Contract);
            this.panel1.Controls.Add(this.button_Individual);
            this.panel1.Controls.Add(this.button_EducationalProgram);
            this.panel1.Location = new System.Drawing.Point(100, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            this.panel1.TabIndex = 2;
            // 
            // button_Contract
            // 
            this.button_Contract.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Contract.Enabled = false;
            this.button_Contract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.button_Contract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Contract.Location = new System.Drawing.Point(7, 69);
            this.button_Contract.Name = "button_Contract";
            this.button_Contract.Size = new System.Drawing.Size(283, 23);
            this.button_Contract.TabIndex = 2;
            this.button_Contract.Text = "Договор";
            this.button_Contract.UseVisualStyleBackColor = false;
            this.button_Contract.Click += new System.EventHandler(this.button_Contract_Click);
            // 
            // button_Individual
            // 
            this.button_Individual.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Individual.Enabled = false;
            this.button_Individual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.button_Individual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Individual.Location = new System.Drawing.Point(7, 40);
            this.button_Individual.Name = "button_Individual";
            this.button_Individual.Size = new System.Drawing.Size(283, 23);
            this.button_Individual.TabIndex = 1;
            this.button_Individual.Text = "Физическое лицо";
            this.button_Individual.UseVisualStyleBackColor = false;
            this.button_Individual.Click += new System.EventHandler(this.button_Individual_Click);
            // 
            // button_EducationalProgram
            // 
            this.button_EducationalProgram.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_EducationalProgram.Enabled = false;
            this.button_EducationalProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.button_EducationalProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EducationalProgram.Location = new System.Drawing.Point(7, 10);
            this.button_EducationalProgram.Name = "button_EducationalProgram";
            this.button_EducationalProgram.Size = new System.Drawing.Size(283, 23);
            this.button_EducationalProgram.TabIndex = 0;
            this.button_EducationalProgram.Text = "Образовательная программа";
            this.button_EducationalProgram.UseVisualStyleBackColor = false;
            this.button_EducationalProgram.Click += new System.EventHandler(this.button_EducationalProgram_Click);
            // 
            // title_Catalog
            // 
            this.title_Catalog.AutoSize = true;
            this.title_Catalog.Location = new System.Drawing.Point(104, 72);
            this.title_Catalog.Name = "title_Catalog";
            this.title_Catalog.Size = new System.Drawing.Size(73, 13);
            this.title_Catalog.TabIndex = 3;
            this.title_Catalog.Text = "Справочники";
            // 
            // CorporateMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.title_Catalog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_AccountExit);
            this.Controls.Add(this.title_FullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CorporateMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЦДО | Корпоративное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CorporateMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CorporateMenu_FormClosed);
            this.Load += new System.EventHandler(this.CorporateMenu_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_FullName;
        private System.Windows.Forms.Button button_AccountExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Contract;
        private System.Windows.Forms.Button button_Individual;
        private System.Windows.Forms.Button button_EducationalProgram;
        private System.Windows.Forms.Label title_Catalog;
    }
}