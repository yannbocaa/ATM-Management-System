namespace ATM_Management_System
{
    partial class HOME
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnFastCash = new System.Windows.Forms.Button();
            this.btnChangePin = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnMiniStatement = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLogoutHome = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lblAccountNumber);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 192);
            this.panel1.TabIndex = 0;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblExit.Location = new System.Drawing.Point(822, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(36, 36);
            this.lblExit.TabIndex = 8;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT YOUR TRANSACTION";
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(71, 255);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(247, 65);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "DEPOSIT";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnFastCash
            // 
            this.btnFastCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFastCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastCash.Location = new System.Drawing.Point(71, 385);
            this.btnFastCash.Name = "btnFastCash";
            this.btnFastCash.Size = new System.Drawing.Size(255, 65);
            this.btnFastCash.TabIndex = 2;
            this.btnFastCash.Text = "FAST CASH";
            this.btnFastCash.UseVisualStyleBackColor = false;
            this.btnFastCash.Click += new System.EventHandler(this.btnFastCash_Click);
            // 
            // btnChangePin
            // 
            this.btnChangePin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChangePin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePin.Location = new System.Drawing.Point(71, 521);
            this.btnChangePin.Name = "btnChangePin";
            this.btnChangePin.Size = new System.Drawing.Size(255, 65);
            this.btnChangePin.TabIndex = 3;
            this.btnChangePin.Text = "PIN CHANGE";
            this.btnChangePin.UseVisualStyleBackColor = false;
            this.btnChangePin.Click += new System.EventHandler(this.btnChangePin_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(493, 255);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(238, 65);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "WITHDRAWAL";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnMiniStatement
            // 
            this.btnMiniStatement.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMiniStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiniStatement.Location = new System.Drawing.Point(493, 385);
            this.btnMiniStatement.Name = "btnMiniStatement";
            this.btnMiniStatement.Size = new System.Drawing.Size(238, 65);
            this.btnMiniStatement.TabIndex = 5;
            this.btnMiniStatement.Text = "MINI STATEMENT";
            this.btnMiniStatement.UseVisualStyleBackColor = false;
            this.btnMiniStatement.Click += new System.EventHandler(this.btnMiniStatement_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalance.Location = new System.Drawing.Point(493, 521);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(238, 65);
            this.btnBalance.TabIndex = 6;
            this.btnBalance.Text = "ACCOUNT BALANCE";
            this.btnBalance.UseVisualStyleBackColor = false;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 718);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 21);
            this.panel2.TabIndex = 1;
            // 
            // lblLogoutHome
            // 
            this.lblLogoutHome.AutoSize = true;
            this.lblLogoutHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoutHome.ForeColor = System.Drawing.Color.Red;
            this.lblLogoutHome.Location = new System.Drawing.Point(342, 633);
            this.lblLogoutHome.Name = "lblLogoutHome";
            this.lblLogoutHome.Size = new System.Drawing.Size(159, 37);
            this.lblLogoutHome.TabIndex = 7;
            this.lblLogoutHome.Text = "LOGOUT";
            this.lblLogoutHome.Click += new System.EventHandler(this.lblLogoutHome_Click);
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.Location = new System.Drawing.Point(257, 129);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(337, 37);
            this.lblAccountNumber.TabIndex = 1;
            this.lblAccountNumber.Text = "ACCOUNT NUMBER";
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(853, 735);
            this.Controls.Add(this.lblLogoutHome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnMiniStatement);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnChangePin);
            this.Controls.Add(this.btnFastCash);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.HOME_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnFastCash;
        private System.Windows.Forms.Button btnChangePin;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnMiniStatement;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLogoutHome;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblExit;
    }
}