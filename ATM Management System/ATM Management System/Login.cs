using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void labelSignUp_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
            this.Hide();
        }
        public static String AccNumber;

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yannb\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT count(*) from AccountTbl where Accnum = '"+textBoxAccountNum.Text+"' and PIN = "+txtBoxPinCode.Text+ "", Con);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                AccNumber = textBoxAccountNum.Text;
                HOME home = new HOME();
                home.Show();
                this.Hide();
                Con.Close();
            }
            else 
            {
                MessageBox.Show("Wrong Account Number or PIN Code!");
            }
            Con.Close();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
