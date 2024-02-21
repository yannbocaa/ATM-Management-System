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
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void lblLogoutHome_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            this.Hide();
            balance.Show();
        }
        public static String AccNumber;
        private void HOME_Load(object sender, EventArgs e)
        {
            lblAccountNumber.Text = "Account Number:" + Login.AccNumber;
            AccNumber = Login.AccNumber;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            this.Hide();
            deposit.Show();
        }

        private void btnFastCash_Click(object sender, EventArgs e)
        {
            FastCASH fastCASH = new FastCASH();
            this.Hide(); 
            fastCASH.Show();
        }

        private void btnMiniStatement_Click(object sender, EventArgs e)
        {
            MiniStatement miniStatement = new MiniStatement();
            this.Hide();
            miniStatement.Show();
        }

        private void btnChangePin_Click(object sender, EventArgs e)
        {
            ChangePin changePin = new ChangePin();
            this.Hide();
            changePin.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            this.Hide();
            withdraw.Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
