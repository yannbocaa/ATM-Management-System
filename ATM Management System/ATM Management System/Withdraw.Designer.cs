namespace ATM_Management_System
{
    partial class Withdraw
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
            this.label5 = new System.Windows.Forms.Label();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.lblAmountWithdraw = new System.Windows.Forms.Label();
            this.txtBoxWithDrawAmount = new System.Windows.Forms.TextBox();
            this.lblAvailableBalance = new System.Windows.Forms.Label();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.lblLogoutWithdraw = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(902, 165);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(486, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblWithdraw.Location = new System.Drawing.Point(372, 187);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(169, 32);
            this.lblWithdraw.TabIndex = 4;
            this.lblWithdraw.Text = "WITHDRAW";
            // 
            // lblAmountWithdraw
            // 
            this.lblAmountWithdraw.AutoSize = true;
            this.lblAmountWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAmountWithdraw.Location = new System.Drawing.Point(206, 343);
            this.lblAmountWithdraw.Name = "lblAmountWithdraw";
            this.lblAmountWithdraw.Size = new System.Drawing.Size(143, 32);
            this.lblAmountWithdraw.TabIndex = 5;
            this.lblAmountWithdraw.Text = "AMOUNT:";
            // 
            // txtBoxWithDrawAmount
            // 
            this.txtBoxWithDrawAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxWithDrawAmount.Location = new System.Drawing.Point(378, 340);
            this.txtBoxWithDrawAmount.Name = "txtBoxWithDrawAmount";
            this.txtBoxWithDrawAmount.Size = new System.Drawing.Size(328, 35);
            this.txtBoxWithDrawAmount.TabIndex = 6;
            // 
            // lblAvailableBalance
            // 
            this.lblAvailableBalance.AutoSize = true;
            this.lblAvailableBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAvailableBalance.Location = new System.Drawing.Point(412, 254);
            this.lblAvailableBalance.Name = "lblAvailableBalance";
            this.lblAvailableBalance.Size = new System.Drawing.Size(306, 32);
            this.lblAvailableBalance.TabIndex = 7;
            this.lblAvailableBalance.Text = "AVAILABLE BALANCE";
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.BackColor = System.Drawing.Color.PeachPuff;
            this.btnWithdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrawal.Location = new System.Drawing.Point(437, 394);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(178, 52);
            this.btnWithdrawal.TabIndex = 8;
            this.btnWithdrawal.Text = "WITHDRAW";
            this.btnWithdrawal.UseVisualStyleBackColor = false;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // lblLogoutWithdraw
            // 
            this.lblLogoutWithdraw.AutoSize = true;
            this.lblLogoutWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoutWithdraw.ForeColor = System.Drawing.Color.Red;
            this.lblLogoutWithdraw.Location = new System.Drawing.Point(467, 471);
            this.lblLogoutWithdraw.Name = "lblLogoutWithdraw";
            this.lblLogoutWithdraw.Size = new System.Drawing.Size(108, 37);
            this.lblLogoutWithdraw.TabIndex = 28;
            this.lblLogoutWithdraw.Text = "BACK";
            this.lblLogoutWithdraw.Click += new System.EventHandler(this.lblLogoutWithdraw_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblExit.Location = new System.Drawing.Point(863, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(36, 36);
            this.lblExit.TabIndex = 29;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAvailable.Location = new System.Drawing.Point(208, 254);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(210, 48);
            this.lblAvailable.TabIndex = 29;
            this.lblAvailable.Text = "Available:";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 591);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblLogoutWithdraw);
            this.Controls.Add(this.btnWithdrawal);
            this.Controls.Add(this.lblAvailableBalance);
            this.Controls.Add(this.txtBoxWithDrawAmount);
            this.Controls.Add(this.lblAmountWithdraw);
            this.Controls.Add(this.lblWithdraw);
            this.Controls.Add(this.panel1);
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.Label lblAmountWithdraw;
        private System.Windows.Forms.TextBox txtBoxWithDrawAmount;
        private System.Windows.Forms.Label lblAvailableBalance;
        private System.Windows.Forms.Button btnWithdrawal;
        private System.Windows.Forms.Label lblLogoutWithdraw;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblAvailable;
    }
}