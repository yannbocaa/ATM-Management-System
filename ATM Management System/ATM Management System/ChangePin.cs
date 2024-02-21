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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yannb\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        String Acc = Login.AccNumber;
        private void lblAccNumBalance_Click(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChangePin_Click(object sender, EventArgs e)
        {
            if (txtBoxNewPin.Text == "" || txtBoxConfirmPin.Text == "")
            {
                MessageBox.Show("Enter and Confirm the new PIN CODE!");
            }
            else if (txtBoxConfirmPin.Text != txtBoxNewPin.Text) 
            {
                MessageBox.Show("Pin codes do not match!");
                MessageBox.Show("Please re-enter the Pin Code");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE AccountTbl set PIN=" + txtBoxNewPin.Text + " WHERE AccNum= '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PIN Code is Updated!");
                    Con.Close();

                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ChangePin_Load(object sender, EventArgs e)
        {

        }

        private void lblLogoutBalance_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }
    }
}
