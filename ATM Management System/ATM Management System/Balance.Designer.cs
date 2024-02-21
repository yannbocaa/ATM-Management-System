namespace ATM_Management_System
{
    partial class Balance
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAccNumBalance = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblYourAccNum = new System.Windows.Forms.Label();
            this.lblYourBalance = new System.Windows.Forms.Label();
            this.lblLogoutBalance = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBack = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 183);
            this.panel1.TabIndex = 0;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblExit.Location = new System.Drawing.Point(881, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(36, 36);
            this.lblExit.TabIndex = 11;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(486, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // lblAccNumBalance
            // 
            this.lblAccNumBalance.AutoSize = true;
            this.lblAccNumBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAccNumBalance.Location = new System.Drawing.Point(99, 280);
            this.lblAccNumBalance.Name = "lblAccNumBalance";
            this.lblAccNumBalance.Size = new System.Drawing.Size(232, 32);
            this.lblAccNumBalance.TabIndex = 1;
            this.lblAccNumBalance.Text = "Account Number:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblBalance.Location = new System.Drawing.Point(99, 367);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(126, 32);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance:";
            // 
            // lblYourAccNum
            // 
            this.lblYourAccNum.AutoSize = true;
            this.lblYourAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblYourAccNum.Location = new System.Drawing.Point(511, 280);
            this.lblYourAccNum.Name = "lblYourAccNum";
            this.lblYourAccNum.Size = new System.Drawing.Size(236, 32);
            this.lblYourAccNum.TabIndex = 3;
            this.lblYourAccNum.Text = "YourAccountNum";
            // 
            // lblYourBalance
            // 
            this.lblYourBalance.AutoSize = true;
            this.lblYourBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblYourBalance.Location = new System.Drawing.Point(511, 367);
            this.lblYourBalance.Name = "lblYourBalance";
            this.lblYourBalance.Size = new System.Drawing.Size(178, 32);
            this.lblYourBalance.TabIndex = 4;
            this.lblYourBalance.Text = "YourBalance";
            // 
            // lblLogoutBalance
            // 
            this.lblLogoutBalance.AutoSize = true;
            this.lblLogoutBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoutBalance.ForeColor = System.Drawing.Color.Red;
            this.lblLogoutBalance.Location = new System.Drawing.Point(347, 454);
            this.lblLogoutBalance.Name = "lblLogoutBalance";
            this.lblLogoutBalance.Size = new System.Drawing.Size(27, 37);
            this.lblLogoutBalance.TabIndex = 8;
            this.lblLogoutBalance.Text = " ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 650);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 16);
            this.panel2.TabIndex = 9;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblBack.Location = new System.Drawing.Point(379, 590);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(129, 46);
            this.lblBack.TabIndex = 10;
            this.lblBack.Text = "BACK";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 666);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblLogoutBalance);
            this.Controls.Add(this.lblYourBalance);
            this.Controls.Add(this.lblAccNumBalance);
            this.Controls.Add(this.lblYourAccNum);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAccNumBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblYourAccNum;
        private System.Windows.Forms.Label lblYourBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLogoutBalance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblExit;
    }
}