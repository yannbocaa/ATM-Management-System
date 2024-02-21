using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM_Management_System
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yannb\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void getBalance() 
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Balance from AccountTbl where AccNum='"+ lblYourAccNum.Text +"'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblYourBalance.Text = dt.Rows[0][0].ToString() + "zl";
            Con.Close();
        }
        private void Balance_Load(object sender, EventArgs e)
        {
            lblYourAccNum.Text = HOME.AccNumber;
            getBalance();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            this.Hide();
            home.Show();
        }
    }
}
