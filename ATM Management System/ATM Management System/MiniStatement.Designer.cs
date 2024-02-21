namespace ATM_Management_System
{
    partial class MiniStatement
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
            this.lblMiniStatement = new System.Windows.Forms.Label();
            this.dataGVMiniStatement = new System.Windows.Forms.DataGridView();
            this.lblLogoutFastCash = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblExit2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMiniStatement)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblExit2);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 136);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(269, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(486, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // lblMiniStatement
            // 
            this.lblMiniStatement.AutoSize = true;
            this.lblMiniStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiniStatement.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblMiniStatement.Location = new System.Drawing.Point(415, 150);
            this.lblMiniStatement.Name = "lblMiniStatement";
            this.lblMiniStatement.Size = new System.Drawing.Size(232, 29);
            this.lblMiniStatement.TabIndex = 3;
            this.lblMiniStatement.Text = "MINI STATEMENT";
            // 
            // dataGVMiniStatement
            // 
            this.dataGVMiniStatement.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGVMiniStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVMiniStatement.Location = new System.Drawing.Point(0, 206);
            this.dataGVMiniStatement.Name = "dataGVMiniStatement";
            this.dataGVMiniStatement.RowHeadersWidth = 62;
            this.dataGVMiniStatement.RowTemplate.Height = 28;
            this.dataGVMiniStatement.Size = new System.Drawing.Size(1044, 466);
            this.dataGVMiniStatement.TabIndex = 4;
            // 
            // lblLogoutFastCash
            // 
            this.lblLogoutFastCash.AutoSize = true;
            this.lblLogoutFastCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoutFastCash.ForeColor = System.Drawing.Color.Red;
            this.lblLogoutFastCash.Location = new System.Drawing.Point(458, 704);
            this.lblLogoutFastCash.Name = "lblLogoutFastCash";
            this.lblLogoutFastCash.Size = new System.Drawing.Size(116, 37);
            this.lblLogoutFastCash.TabIndex = 28;
            this.lblLogoutFastCash.Text = "HOME";
            this.lblLogoutFastCash.Click += new System.EventHandler(this.lblLogoutFastCash_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblExit.Location = new System.Drawing.Point(1142, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(54, 54);
            this.lblExit.TabIndex = 3;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblExit2
            // 
            this.lblExit2.AutoSize = true;
            this.lblExit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblExit2.Location = new System.Drawing.Point(1007, 0);
            this.lblExit2.Name = "lblExit2";
            this.lblExit2.Size = new System.Drawing.Size(36, 36);
            this.lblExit2.TabIndex = 4;
            this.lblExit2.Text = "X";
            this.lblExit2.Click += new System.EventHandler(this.lblExit2_Click);
            // 
            // MiniStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 750);
            this.Controls.Add(this.lblLogoutFastCash);
            this.Controls.Add(this.dataGVMiniStatement);
            this.Controls.Add(this.lblMiniStatement);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MiniStatement";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniStatement";
            this.Load += new System.EventHandler(this.MiniStatement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMiniStatement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMiniStatement;
        private System.Windows.Forms.DataGridView dataGVMiniStatement;
        private System.Windows.Forms.Label lblLogoutFastCash;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblExit2;
    }
}