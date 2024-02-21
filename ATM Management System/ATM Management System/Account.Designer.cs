namespace ATM_Management_System
{
    partial class Account
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
            this.lblAccNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblEducation = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.AccNumTb = new System.Windows.Forms.TextBox();
            this.AccPinTb = new System.Windows.Forms.TextBox();
            this.AccAddressTb = new System.Windows.Forms.TextBox();
            this.AccSurnameTb = new System.Windows.Forms.TextBox();
            this.AccNameTb = new System.Windows.Forms.TextBox();
            this.comboBoxEducation = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AccPhoneTb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoginAccount = new System.Windows.Forms.Button();
            this.OccupationTb = new System.Windows.Forms.TextBox();
            this.lblLogoutAccount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccNo
            // 
            this.lblAccNo.AutoSize = true;
            this.lblAccNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAccNo.Location = new System.Drawing.Point(40, 198);
            this.lblAccNo.Name = "lblAccNo";
            this.lblAccNo.Size = new System.Drawing.Size(123, 29);
            this.lblAccNo.TabIndex = 0;
            this.lblAccNo.Text = "ACC NUM";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(40, 286);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "NAME";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLastName.Location = new System.Drawing.Point(40, 377);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(132, 29);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "SURNAME";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAddress.Location = new System.Drawing.Point(40, 462);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(127, 29);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "ADDRESS";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPhone.Location = new System.Drawing.Point(630, 447);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(99, 29);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "PHONE";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBalance.Location = new System.Drawing.Point(630, 263);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 29);
            this.lblBalance.TabIndex = 5;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPin.Location = new System.Drawing.Point(630, 182);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(53, 29);
            this.lblPin.TabIndex = 6;
            this.lblPin.Text = "PIN";
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEducation.Location = new System.Drawing.Point(630, 254);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(154, 29);
            this.lblEducation.TabIndex = 7;
            this.lblEducation.Text = "EDUCATION";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOccupation.Location = new System.Drawing.Point(630, 350);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(173, 29);
            this.lblOccupation.TabIndex = 8;
            this.lblOccupation.Text = "OCCUPATION";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDOB.Location = new System.Drawing.Point(639, 536);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(65, 29);
            this.lblDOB.TabIndex = 9;
            this.lblDOB.Text = "DOB";
            // 
            // AccNumTb
            // 
            this.AccNumTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AccNumTb.Location = new System.Drawing.Point(200, 198);
            this.AccNumTb.Name = "AccNumTb";
            this.AccNumTb.Size = new System.Drawing.Size(323, 30);
            this.AccNumTb.TabIndex = 10;
            // 
            // AccPinTb
            // 
            this.AccPinTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AccPinTb.Location = new System.Drawing.Point(840, 182);
            this.AccPinTb.Name = "AccPinTb";
            this.AccPinTb.Size = new System.Drawing.Size(305, 30);
            this.AccPinTb.TabIndex = 11;
            // 
            // AccAddressTb
            // 
            this.AccAddressTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AccAddressTb.Location = new System.Drawing.Point(200, 446);
            this.AccAddressTb.Multiline = true;
            this.AccAddressTb.Name = "AccAddressTb";
            this.AccAddressTb.Size = new System.Drawing.Size(278, 165);
            this.AccAddressTb.TabIndex = 12;
            this.AccAddressTb.TextChanged += new System.EventHandler(this.AccAddressTb_TextChanged);
            // 
            // AccSurnameTb
            // 
            this.AccSurnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AccSurnameTb.Location = new System.Drawing.Point(200, 371);
            this.AccSurnameTb.Name = "AccSurnameTb";
            this.AccSurnameTb.Size = new System.Drawing.Size(323, 30);
            this.AccSurnameTb.TabIndex = 14;
            // 
            // AccNameTb
            // 
            this.AccNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AccNameTb.Location = new System.Drawing.Point(200, 286);
            this.AccNameTb.Name = "AccNameTb";
            this.AccNameTb.Size = new System.Drawing.Size(323, 30);
            this.AccNameTb.TabIndex = 15;
            // 
            // comboBoxEducation
            // 
            this.comboBoxEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxEducation.FormattingEnabled = true;
            this.comboBoxEducation.Items.AddRange(new object[] {
            "None",
            "High School",
            "Bachelor\'s Degree",
            "Master\'s Degree",
            "PHD"});
            this.comboBoxEducation.Location = new System.Drawing.Point(849, 254);
            this.comboBoxEducation.Name = "comboBoxEducation";
            this.comboBoxEducation.Size = new System.Drawing.Size(296, 33);
            this.comboBoxEducation.TabIndex = 19;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker.Location = new System.Drawing.Point(856, 546);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(296, 30);
            this.dateTimePicker.TabIndex = 21;
            // 
            // AccPhoneTb
            // 
            this.AccPhoneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AccPhoneTb.Location = new System.Drawing.Point(849, 446);
            this.AccPhoneTb.Name = "AccPhoneTb";
            this.AccPhoneTb.Size = new System.Drawing.Size(303, 30);
            this.AccPhoneTb.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 173);
            this.panel1.TabIndex = 23;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblExit.Location = new System.Drawing.Point(1198, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(47, 46);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 32);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(486, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // btnLoginAccount
            // 
            this.btnLoginAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLoginAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAccount.Location = new System.Drawing.Point(561, 634);
            this.btnLoginAccount.Name = "btnLoginAccount";
            this.btnLoginAccount.Size = new System.Drawing.Size(223, 67);
            this.btnLoginAccount.TabIndex = 24;
            this.btnLoginAccount.Text = "LOGIN";
            this.btnLoginAccount.UseVisualStyleBackColor = false;
            this.btnLoginAccount.Click += new System.EventHandler(this.btnLoginAccount_Click);
            // 
            // OccupationTb
            // 
            this.OccupationTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OccupationTb.Location = new System.Drawing.Point(849, 349);
            this.OccupationTb.Name = "OccupationTb";
            this.OccupationTb.Size = new System.Drawing.Size(296, 30);
            this.OccupationTb.TabIndex = 25;
            // 
            // lblLogoutAccount
            // 
            this.lblLogoutAccount.AutoSize = true;
            this.lblLogoutAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoutAccount.ForeColor = System.Drawing.Color.Red;
            this.lblLogoutAccount.Location = new System.Drawing.Point(590, 744);
            this.lblLogoutAccount.Name = "lblLogoutAccount";
            this.lblLogoutAccount.Size = new System.Drawing.Size(159, 37);
            this.lblLogoutAccount.TabIndex = 28;
            this.lblLogoutAccount.Text = "LOGOUT";
            this.lblLogoutAccount.Click += new System.EventHandler(this.lblLogoutAccount_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 819);
            this.Controls.Add(this.lblLogoutAccount);
            this.Controls.Add(this.OccupationTb);
            this.Controls.Add(this.btnLoginAccount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AccPhoneTb);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxEducation);
            this.Controls.Add(this.AccNameTb);
            this.Controls.Add(this.AccSurnameTb);
            this.Controls.Add(this.AccAddressTb);
            this.Controls.Add(this.AccPinTb);
            this.Controls.Add(this.AccNumTb);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblOccupation);
            this.Controls.Add(this.lblEducation);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAccNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox AccNumTb;
        private System.Windows.Forms.TextBox AccPinTb;
        private System.Windows.Forms.TextBox AccAddressTb;
        private System.Windows.Forms.TextBox AccSurnameTb;
        private System.Windows.Forms.TextBox AccNameTb;
        private System.Windows.Forms.ComboBox comboBoxEducation;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox AccPhoneTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoginAccount;
        private System.Windows.Forms.TextBox OccupationTb;
        private System.Windows.Forms.Label lblLogoutAccount;
        private System.Windows.Forms.Label lblExit;
    }
}