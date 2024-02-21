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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yannb\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        String Acc = Login.AccNumber;
        int bal;
        int newBalance;
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLogoutWithdraw_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Balance from AccountTbl where AccNum='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblAvailableBalance.Text = dt.Rows[0][0].ToString() + "zl";
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void addTransaction()
        {
            string TryType = "Withdraw";
            try
            {
                Con.Open();
                string query = "INSERT INTO TransactionTbl VALUES(@Acc, @TryType, @Amount, @TransactionDate)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@Acc", Acc);
                cmd.Parameters.AddWithValue("@TryType", TryType);
                cmd.Parameters.AddWithValue("@Amount", txtBoxWithDrawAmount.Text);
                cmd.Parameters.AddWithValue("@TransactionDate", DateTime.Today.Date);
                cmd.ExecuteNonQuery();
                //  MessageBox.Show("Account Created Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
           

        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            if (txtBoxWithDrawAmount.Text == "")
            {
                MessageBox.Show("Enter Amount To Withdraw!");
            }
            else if (Convert.ToInt32(txtBoxWithDrawAmount.Text) <= 0)
            {
                MessageBox.Show("Enter a Valid Amount!");
            }
            else if (Convert.ToInt32(txtBoxWithDrawAmount.Text) > bal)
            {
                MessageBox.Show("Amount to Withdraw is greater than Account Balance!");
            }
            else
            {
                try
                {
                    newBalance = bal - Convert.ToInt32(txtBoxWithDrawAmount.Text);
                    try
                    {
                        Con.Open();
                        string query = "UPDATE AccountTbl set Balance=" + newBalance + " WHERE AccNum= '" + Acc + "';";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful Withdrawal!");
                        Con.Close();

                        addTransaction();

                        HOME home = new HOME();
                        home.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        } 

        private void Withdraw_Load(object sender, EventArgs e)
        {
            getBalance();
        }
    }
}
