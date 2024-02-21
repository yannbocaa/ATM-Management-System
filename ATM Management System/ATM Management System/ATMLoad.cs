using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Management_System
{
    public partial class ATMLoad : Form
    {
        public ATMLoad()
        {
            InitializeComponent();
        }
        int starting = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starting += 1;
            progressBarLoading.Value = starting;
            lblPercentage.Text = "" + starting + "%";
            if (progressBarLoading.Value == 100) 
            {
                progressBarLoading.Value = 0;
                timer1.Stop();
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }

        private void ATMLoad_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
