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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        string Acc = Login.AccNumber;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yannb\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void addTransaction() 
        {
            string TryType = "Deposit";
            try
            {
                Con.Open();
                string query = "INSERT INTO TransactionTbl VALUES(@Acc, @TryType, @Amount, @TransactionDate)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@Acc", Acc);
                cmd.Parameters.AddWithValue("@TryType", TryType);
                cmd.Parameters.AddWithValue("@Amount", DepositAmountTb.Text);
                cmd.Parameters.AddWithValue("@TransactionDate", DateTime.Today.Date);
                cmd.ExecuteNonQuery();
              
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
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (DepositAmountTb.Text == "" || Convert.ToInt32(DepositAmountTb.Text) <= 0)
            {
                MessageBox.Show("Enter the Amount to Deposit!");
            }
            else 
            {
               
                newBalance = oldBalance + Convert.ToInt32(DepositAmountTb.Text);
                try
                {
                    Con.Open();
                    string query = "UPDATE AccountTbl set Balance=" + newBalance + " WHERE AccNum= '" +Acc+ "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your amount has been deposited!");
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
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLogoutDeposit_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }
        int oldBalance, newBalance;
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Balance from AccountTbl where AccNum='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldBalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void Deposit_Load(object sender, EventArgs e)
        {
          getBalance();
        }
    }
}
