namespace ATM_Management_System
{
    partial class Deposit
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAccNumBalance = new System.Windows.Forms.Label();
            this.DepositAmountTb = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblLogoutDeposit = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(895, 149);
            this.panel1.TabIndex = 2;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblExit.Location = new System.Drawing.Point(856, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(36, 36);
            this.lblExit.TabIndex = 3;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(486, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // lblAccNumBalance
            // 
            this.lblAccNumBalance.AutoSize = true;
            this.lblAccNumBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAccNumBalance.Location = new System.Drawing.Point(216, 267);
            this.lblAccNumBalance.Name = "lblAccNumBalance";
            this.lblAccNumBalance.Size = new System.Drawing.Size(143, 32);
            this.lblAccNumBalance.TabIndex = 3;
            this.lblAccNumBalance.Text = "AMOUNT:";
            // 
            // DepositAmountTb
            // 
            this.DepositAmountTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DepositAmountTb.Location = new System.Drawing.Point(388, 264);
            this.DepositAmountTb.Name = "DepositAmountTb";
            this.DepositAmountTb.Size = new System.Drawing.Size(303, 35);
            this.DepositAmountTb.TabIndex = 4;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(441, 329);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(191, 53);
            this.btnDeposit.TabIndex = 5;
            this.btnDeposit.Text = "DEPOSIT";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblLogoutDeposit
            // 
            this.lblLogoutDeposit.AutoSize = true;
            this.lblLogoutDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoutDeposit.ForeColor = System.Drawing.Color.Red;
            this.lblLogoutDeposit.Location = new System.Drawing.Point(481, 413);
            this.lblLogoutDeposit.Name = "lblLogoutDeposit";
            this.lblLogoutDeposit.Size = new System.Drawing.Size(108, 37);
            this.lblLogoutDeposit.TabIndex = 27;
            this.lblLogoutDeposit.Text = "BACK";
            this.lblLogoutDeposit.Click += new System.EventHandler(this.lblLogoutDeposit_Click);
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDeposit.Location = new System.Drawing.Point(460, 181);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(163, 37);
            this.lblDeposit.TabIndex = 28;
            this.lblDeposit.Text = "DEPOSIT";
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 502);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblLogoutDeposit);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.DepositAmountTb);
            this.Controls.Add(this.lblAccNumBalance);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAccNumBalance;
        private System.Windows.Forms.TextBox DepositAmountTb;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblLogoutDeposit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblExit;
    }
}