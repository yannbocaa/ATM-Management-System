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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yannb\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnLoginAccount_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccNameTb.Text == "" || AccNumTb.Text == "" || AccSurnameTb.Text == "" || AccPhoneTb.Text == "" ||
                AccAddressTb.Text == "" || OccupationTb.Text == "" || AccPinTb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try 
                { 
                    Con.Open();
                    /*string query = "insert into AccountTbl values('"+AccNumTb.Text+"', '"+AccNameTb.Text+ "','"+AccSurnameTb.Text+ "', " +
                        "'"+dateTimePicker.Value.Date+ "', '"+AccPhoneTb.Text+ "', '"+AccAddressTb.Text+ "', " +
                        "'"+comboBoxEducation.SelectedItem.ToString()+ "', '"+OccupationTb.Text+ "', "+AccPinTb.Text+", "+bal+")";*/
                    string query = "INSERT INTO AccountTbl VALUES(@AccNum, @AccName, @AccSurname, @AccAddress, @AccPin, @AccEducation, @Phone, @AccOccupation, @AccBirthDate, @Balance)";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.Parameters.AddWithValue("@AccNum", AccNumTb.Text);
                    cmd.Parameters.AddWithValue("@AccName", AccNameTb.Text);
                    cmd.Parameters.AddWithValue("@AccSurname", AccSurnameTb.Text);
                    cmd.Parameters.AddWithValue("@AccAddress", AccAddressTb.Text);
                    cmd.Parameters.AddWithValue("@AccPin", AccPinTb.Text);
                    cmd.Parameters.AddWithValue("@AccEducation", comboBoxEducation.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AccOccupation", OccupationTb.Text);
                    cmd.Parameters.AddWithValue("@Phone", AccPhoneTb.Text);
                    cmd.Parameters.AddWithValue("AccBirthDate", dateTimePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@Balance", bal);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully!");
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
        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void AccAddressTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLogoutAccount_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
