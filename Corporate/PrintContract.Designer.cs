namespace cdo_den
{
    partial class PrintContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintContract));
            this.pictureBox_Ticket = new System.Windows.Forms.PictureBox();
            this.button_ContractPDF = new System.Windows.Forms.Button();
            this.button_ContractPrint = new System.Windows.Forms.Button();
            this.button_ContractDocx = new System.Windows.Forms.Button();
            this.button_TicketDocx = new System.Windows.Forms.Button();
            this.button_TicketPrint = new System.Windows.Forms.Button();
            this.button_TicketPDF = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Ticket = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Contract = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ticket)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Ticket
            // 
            this.pictureBox_Ticket.Location = new System.Drawing.Point(10, 10);
            this.pictureBox_Ticket.Name = "pictureBox_Ticket";
            this.pictureBox_Ticket.Size = new System.Drawing.Size(650, 350);
            this.pictureBox_Ticket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Ticket.TabIndex = 0;
            this.pictureBox_Ticket.TabStop = false;
            // 
            // button_ContractPDF
            // 
            this.button_ContractPDF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_ContractPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.button_ContractPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ContractPDF.Location = new System.Drawing.Point(84, 9);
            this.button_ContractPDF.Name = "button_ContractPDF";
            this.button_ContractPDF.Size = new System.Drawing.Size(75, 23);
            this.button_ContractPDF.TabIndex = 2;
            this.button_ContractPDF.Text = "PDF";
            this.button_ContractPDF.UseVisualStyleBackColor = false;
            this.button_ContractPDF.Click += new System.EventHandler(this.button_ContractPDF_Click);
            // 
            // button_ContractPrint
            // 
            this.button_ContractPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_ContractPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.button_ContractPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ContractPrint.Location = new System.Drawing.Point(165, 9);
            this.button_ContractPrint.Name = "button_ContractPrint";
            this.button_ContractPrint.Size = new System.Drawing.Size(75, 23);
            this.button_ContractPrint.TabIndex = 3;
            this.button_ContractPrint.Text = "Печать";
            this.button_ContractPrint.UseVisualStyleBackColor = false;
            this.button_ContractPrint.Click += new System.EventHandler(this.button_ContractPrint_Click);
            // 
            // button_ContractDocx
            // 
            this.button_ContractDocx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_ContractDocx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.button_ContractDocx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ContractDocx.Location = new System.Drawing.Point(3, 9);
            this.button_ContractDocx.Name = "button_ContractDocx";
            this.button_ContractDocx.Size = new System.Drawing.Size(75, 23);
            this.button_ContractDocx.TabIndex = 4;
            this.button_ContractDocx.Text = "DOCX";
            this.button_ContractDocx.UseVisualStyleBackColor = false;
            this.button_ContractDocx.Click += new System.EventHandler(this.button_ContractDocx_Click);
            // 
            // button_TicketDocx
            // 
            this.button_TicketDocx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_TicketDocx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.button_TicketDocx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TicketDocx.Location = new System.Drawing.Point(3, 9);
            this.button_TicketDocx.Name = "button_TicketDocx";
            this.button_TicketDocx.Size = new System.Drawing.Size(75, 23);
            this.button_TicketDocx.TabIndex = 7;
            this.button_TicketDocx.Text = "DOCX";
            this.button_TicketDocx.UseVisualStyleBackColor = false;
            this.button_TicketDocx.Click += new System.EventHandler(this.button_TicketDocx_Click);
            // 
            // button_TicketPrint
            // 
            this.button_TicketPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_TicketPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.button_TicketPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TicketPrint.Location = new System.Drawing.Point(165, 9);
            this.button_TicketPrint.Name = "button_TicketPrint";
            this.button_TicketPrint.Size = new System.Drawing.Size(75, 23);
            this.button_TicketPrint.TabIndex = 6;
            this.button_TicketPrint.Text = "Печать";
            this.button_TicketPrint.UseVisualStyleBackColor = false;
            this.button_TicketPrint.Click += new System.EventHandler(this.button_TicketPrint_Click);
            // 
            // button_TicketPDF
            // 
            this.button_TicketPDF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_TicketPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.button_TicketPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TicketPDF.Location = new System.Drawing.Point(84, 9);
            this.button_TicketPDF.Name = "button_TicketPDF";
            this.button_TicketPDF.Size = new System.Drawing.Size(75, 23);
            this.button_TicketPDF.TabIndex = 5;
            this.button_TicketPDF.Text = "PDF";
            this.button_TicketPDF.UseVisualStyleBackColor = false;
            this.button_TicketPDF.Click += new System.EventHandler(this.button_TicketPDF_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_TicketDocx);
            this.panel1.Controls.Add(this.button_TicketPDF);
            this.panel1.Controls.Add(this.button_TicketPrint);
            this.panel1.Location = new System.Drawing.Point(10, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 37);
            this.panel1.TabIndex = 8;
            // 
            // label_Ticket
            // 
            this.label_Ticket.AutoSize = true;
            this.label_Ticket.Location = new System.Drawing.Point(15, 362);
            this.label_Ticket.Name = "label_Ticket";
            this.label_Ticket.Size = new System.Drawing.Size(61, 13);
            this.label_Ticket.TabIndex = 9;
            this.label_Ticket.Text = "Квитанция";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_ContractDocx);
            this.panel2.Controls.Add(this.button_ContractPDF);
            this.panel2.Controls.Add(this.button_ContractPrint);
            this.panel2.Location = new System.Drawing.Point(413, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 37);
            this.panel2.TabIndex = 10;
            // 
            // label_Contract
            // 
            this.label_Contract.AutoSize = true;
            this.label_Contract.Location = new System.Drawing.Point(418, 362);
            this.label_Contract.Name = "label_Contract";
            this.label_Contract.Size = new System.Drawing.Size(51, 13);
            this.label_Contract.TabIndex = 11;
            this.label_Contract.Text = "Договор";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // PrintContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 417);
            this.Controls.Add(this.label_Contract);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_Ticket);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_Ticket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrintContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЦДО | Квитанция и договор";
            this.Load += new System.EventHandler(this.PrintContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ticket)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Ticket;
        private System.Windows.Forms.Button button_ContractPDF;
        private System.Windows.Forms.Button button_ContractPrint;
        private System.Windows.Forms.Button button_ContractDocx;
        private System.Windows.Forms.Button button_TicketDocx;
        private System.Windows.Forms.Button button_TicketPrint;
        private System.Windows.Forms.Button button_TicketPDF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Ticket;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Contract;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}