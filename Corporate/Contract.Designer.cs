namespace cdo_den
{
    partial class Contract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contract));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Print = new System.Windows.Forms.Button();
            this.button_EditContract = new System.Windows.Forms.Button();
            this.button_DeleteContract = new System.Windows.Forms.Button();
            this.button_AddContract = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button_EditContract);
            this.panel1.Controls.Add(this.button_DeleteContract);
            this.panel1.Controls.Add(this.button_AddContract);
            this.panel1.Location = new System.Drawing.Point(13, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 99);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_Print);
            this.panel2.Location = new System.Drawing.Point(134, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 99);
            this.panel2.TabIndex = 3;
            // 
            // button_Print
            // 
            this.button_Print.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.button_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Print.Location = new System.Drawing.Point(4, 11);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(196, 23);
            this.button_Print.TabIndex = 0;
            this.button_Print.Text = "Печать квитанции и договора";
            this.button_Print.UseVisualStyleBackColor = false;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // button_EditContract
            // 
            this.button_EditContract.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_EditContract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.button_EditContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EditContract.Location = new System.Drawing.Point(5, 69);
            this.button_EditContract.Name = "button_EditContract";
            this.button_EditContract.Size = new System.Drawing.Size(124, 23);
            this.button_EditContract.TabIndex = 2;
            this.button_EditContract.Text = "Изменить";
            this.button_EditContract.UseVisualStyleBackColor = false;
            this.button_EditContract.Click += new System.EventHandler(this.button_EditContract_Click);
            // 
            // button_DeleteContract
            // 
            this.button_DeleteContract.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_DeleteContract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.button_DeleteContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DeleteContract.Location = new System.Drawing.Point(5, 40);
            this.button_DeleteContract.Name = "button_DeleteContract";
            this.button_DeleteContract.Size = new System.Drawing.Size(124, 23);
            this.button_DeleteContract.TabIndex = 1;
            this.button_DeleteContract.Text = "Удалить";
            this.button_DeleteContract.UseVisualStyleBackColor = false;
            this.button_DeleteContract.Click += new System.EventHandler(this.button_DeleteContract_Click);
            // 
            // button_AddContract
            // 
            this.button_AddContract.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_AddContract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.button_AddContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddContract.Location = new System.Drawing.Point(5, 11);
            this.button_AddContract.Name = "button_AddContract";
            this.button_AddContract.Size = new System.Drawing.Size(124, 23);
            this.button_AddContract.TabIndex = 0;
            this.button_AddContract.Text = "Добавить";
            this.button_AddContract.UseVisualStyleBackColor = false;
            this.button_AddContract.Click += new System.EventHandler(this.button_AddContract_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Действия с договором";
            // 
            // Contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Contract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЦДО | Договоры";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Contract_FormClosed);
            this.Load += new System.EventHandler(this.Contract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_EditContract;
        private System.Windows.Forms.Button button_DeleteContract;
        private System.Windows.Forms.Button button_AddContract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Print;
    }
}