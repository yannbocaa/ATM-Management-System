namespace ATM_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAccNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPinCode = new System.Windows.Forms.TextBox();
            this.textBoxAccountNum = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(717, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblAccNum
            // 
            this.lblAccNum.AutoSize = true;
            this.lblAccNum.BackColor = System.Drawing.SystemColors.Control;
            this.lblAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAccNum.Location = new System.Drawing.Point(246, 132);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(256, 29);
            this.lblAccNum.TabIndex = 4;
            this.lblAccNum.Text = "ACCOUNT NUMBER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(246, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "PIN CODE";
            // 
            // txtBoxPinCode
            // 
            this.txtBoxPinCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxPinCode.Location = new System.Drawing.Point(543, 233);
            this.txtBoxPinCode.Name = "txtBoxPinCode";
            this.txtBoxPinCode.PasswordChar = '*';
            this.txtBoxPinCode.Size = new System.Drawing.Size(486, 35);
            this.txtBoxPinCode.TabIndex = 7;
            // 
            // textBoxAccountNum
            // 
            this.textBoxAccountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxAccountNum.Location = new System.Drawing.Point(543, 132);
            this.textBoxAccountNum.Name = "textBoxAccountNum";
            this.textBoxAccountNum.Size = new System.Drawing.Size(486, 35);
            this.textBoxAccountNum.TabIndex = 9;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(675, 305);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(223, 67);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.BackColor = System.Drawing.SystemColors.Control;
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblSignUp.Location = new System.Drawing.Point(1175, 623);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(145, 37);
            this.lblSignUp.TabIndex = 10;
            this.lblSignUp.Text = "SIGNUP";
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUp.ForeColor = System.Drawing.Color.Lime;
            this.labelSignUp.Location = new System.Drawing.Point(740, 387);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(110, 29);
            this.labelSignUp.TabIndex = 11;
            this.labelSignUp.Text = "SIGNUP";
            this.labelSignUp.Click += new System.EventHandler(this.labelSignUp_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblExit.Location = new System.Drawing.Point(1030, -4);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(36, 36);
            this.lblExit.TabIndex = 12;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 461);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.labelSignUp);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBoxAccountNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPinCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAccNum);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAccNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPinCode;
        private System.Windows.Forms.TextBox textBoxAccountNum;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label labelSignUp;
        private System.Windows.Forms.Label lblExit;
    }
}