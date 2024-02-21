namespace ATM_Management_System
{
    partial class ChangePin
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
            this.txtBoxNewPin = new System.Windows.Forms.TextBox();
            this.txtBoxConfirmPin = new System.Windows.Forms.TextBox();
            this.btnChangePin = new System.Windows.Forms.Button();
            this.lblLogoutBalance = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
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
            this.panel1.Size = new System.Drawing.Size(852, 191);
            this.panel1.TabIndex = 1;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblExit.Location = new System.Drawing.Point(814, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(36, 36);
            this.lblExit.TabIndex = 27;
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
            this.lblAccNumBalance.Location = new System.Drawing.Point(180, 239);
            this.lblAccNumBalance.Name = "lblAccNumBalance";
            this.lblAccNumBalance.Size = new System.Drawing.Size(140, 32);
            this.lblAccNumBalance.TabIndex = 2;
            this.lblAccNumBalance.Text = "NEW PIN:";
            this.lblAccNumBalance.Click += new System.EventHandler(this.lblAccNumBalance_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblBalance.Location = new System.Drawing.Point(170, 318);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(204, 32);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "CONFIRM PIN:";
            // 
            // txtBoxNewPin
            // 
            this.txtBoxNewPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxNewPin.Location = new System.Drawing.Point(407, 239);
            this.txtBoxNewPin.Name = "txtBoxNewPin";
            this.txtBoxNewPin.Size = new System.Drawing.Size(254, 35);
            this.txtBoxNewPin.TabIndex = 4;
            // 
            // txtBoxConfirmPin
            // 
            this.txtBoxConfirmPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxConfirmPin.Location = new System.Drawing.Point(407, 318);
            this.txtBoxConfirmPin.Name = "txtBoxConfirmPin";
            this.txtBoxConfirmPin.Size = new System.Drawing.Size(254, 35);
            this.txtBoxConfirmPin.TabIndex = 5;
            // 
            // btnChangePin
            // 
            this.btnChangePin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChangePin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePin.Location = new System.Drawing.Point(431, 376);
            this.btnChangePin.Name = "btnChangePin";
            this.btnChangePin.Size = new System.Drawing.Size(206, 50);
            this.btnChangePin.TabIndex = 25;
            this.btnChangePin.Text = "CHANGE";
            this.btnChangePin.UseVisualStyleBackColor = false;
            this.btnChangePin.Click += new System.EventHandler(this.btnChangePin_Click);
            // 
            // lblLogoutBalance
            // 
            this.lblLogoutBalance.AutoSize = true;
            this.lblLogoutBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoutBalance.ForeColor = System.Drawing.Color.Red;
            this.lblLogoutBalance.Location = new System.Drawing.Point(480, 448);
            this.lblLogoutBalance.Name = "lblLogoutBalance";
            this.lblLogoutBalance.Size = new System.Drawing.Size(108, 37);
            this.lblLogoutBalance.TabIndex = 26;
            this.lblLogoutBalance.Text = "BACK";
            this.lblLogoutBalance.Click += new System.EventHandler(this.lblLogoutBalance_Click);
            // 
            // ChangePin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 529);
            this.Controls.Add(this.lblLogoutBalance);
            this.Controls.Add(this.btnChangePin);
            this.Controls.Add(this.txtBoxConfirmPin);
            this.Controls.Add(this.txtBoxNewPin);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblAccNumBalance);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePin";
            this.Load += new System.EventHandler(this.ChangePin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAccNumBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBoxNewPin;
        private System.Windows.Forms.TextBox txtBoxConfirmPin;
        private System.Windows.Forms.Button btnChangePin;
        private System.Windows.Forms.Label lblLogoutBalance;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label lblExit;
    }
}