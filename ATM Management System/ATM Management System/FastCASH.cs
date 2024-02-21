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
    public partial class FastCASH : Form
    {
        public FastCASH()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yannb\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        String Acc = Login.AccNumber;
        int bal;
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Balance from AccountTbl where AccNum='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblAvailable.Text = dt.Rows[0][0].ToString() + "zl";
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }
        int amt1= 100, amt2 = 250, amt3 = 500, amt4 = 1000, amt5 = 1500, amt6 = 2000;
        private void addTransaction()
        {
            string TryType = "Withdrawal";
            try
            {
                Con.Open();
                string query = "INSERT INTO TransactionTbl VALUES(@Acc, @TryType, @Amount, @TransactionDate)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@Acc", Acc);
                cmd.Parameters.AddWithValue("@TryType", TryType);
                cmd.Parameters.AddWithValue("@Amount", amt1);
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
        private void addTransaction2()
        {
            string TryType = "Withdrawal";
            try
            {
                Con.Open();
                string query = "INSERT INTO TransactionTbl VALUES(@Acc, @TryType, @Amount, @TransactionDate)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@Acc", Acc);
                cmd.Parameters.AddWithValue("@TryType", TryType);
                cmd.Parameters.AddWithValue("@Amount", amt2);
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
        private void addTransaction3()
        {
            string TryType = "Withdrawal";
            try
            {
                Con.Open();
                string query = "INSERT INTO TransactionTbl VALUES(@Acc, @TryType, @Amount, @TransactionDate)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@Acc", Acc);
                cmd.Parameters.AddWithValue("@TryType", TryType);
                cmd.Parameters.AddWithValue("@Amount", amt3);
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
        private void addTransaction4()
        {
            string TryType = "Withdrawal";
            try
            {
                Con.Open();
                string query = "INSERT INTO TransactionTbl VALUES(@Acc, @TryType, @Amount, @TransactionDate)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@Acc", Acc);
                cmd.Parameters.AddWithValue("@TryType", TryType);
                cmd.Parameters.AddWithValue("@Amount", amt4);
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
        private void addTransaction5()
        {
            string TryType = "Withdrawal";
            try
            {
                Con.Open();
                string query = "INSERT INTO TransactionTbl VALUES(@Acc, @TryType, @Amount, @TransactionDate)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@Acc", Acc);
                cmd.Parameters.AddWithValue("@TryType", TryType);
                cmd.Parameters.AddWithValue("@Amount", amt5);
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
        private void addTransaction6()
        {
            string TryType = "Withdrawal";
            try
            {
                Con.Open();
                string query = "INSERT INTO TransactionTbl VALUES(@Acc, @TryType, @Amount, @TransactionDate)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@Acc", Acc);
                cmd.Parameters.AddWithValue("@TryType", TryType);
                cmd.Parameters.AddWithValue("@Amount", amt6);
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
        private void lblFastCash_Click(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLogoutFastCash_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void FastCASH_Load(object sender, EventArgs e)
        {
            getBalance();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            if (bal < 100)
            {
                MessageBox.Show("Amount greater than Balance!");
            }
            else 
            {
               int newBalance = bal - 100;
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
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            if (bal < 250)
            {
                MessageBox.Show("Amount greater than Balance!");
            }
            else
            {
                int newBalance = bal - 250;
                try
                {
                    Con.Open();
                    string query = "UPDATE AccountTbl set Balance=" + newBalance + " WHERE AccNum= '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Withdrawal!");
                    Con.Close();

                    addTransaction2();

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

        private void btn500_Click(object sender, EventArgs e)
        {
            if (bal < 500)
            {
                MessageBox.Show("Amount greater than Balance!");
            }
            else
            {
                int newBalance = bal - 500;
                try
                {
                    Con.Open();
                    string query = "UPDATE AccountTbl set Balance=" + newBalance + " WHERE AccNum= '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Withdrawal!");
                    Con.Close();

                    addTransaction3();

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

        private void btn1000_Click(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show("Amount greater than Balance!");
            }
            else
            {
                int newBalance = bal - 1000;
                try
                {
                    Con.Open();
                    string query = "UPDATE AccountTbl set Balance=" + newBalance + " WHERE AccNum= '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Withdrawal!");
                    Con.Close();
                    addTransaction4();
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

        private void btn1500_Click(object sender, EventArgs e)
        {
            if (bal < 1500)
            {
                MessageBox.Show("Amount greater than Balance!");
            }
            else
            {
                int newBalance = bal - 1500;
                try
                {
                    Con.Open();
                    string query = "UPDATE AccountTbl set Balance=" + newBalance + " WHERE AccNum= '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Withdrawal!");
                    Con.Close();
                    addTransaction5();
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

        private void btn2000_Click(object sender, EventArgs e)
        {
            if (bal < 2000)
            {
                MessageBox.Show("Amount greater than Balance!");
            }
            else
            {
                int newBalance = bal - 2000;
                try
                {
                    Con.Open();
                    string query = "UPDATE AccountTbl set Balance=" + newBalance + " WHERE AccNum= '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Withdrawal!");
                    Con.Close();
                    addTransaction6();
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
    }
}
