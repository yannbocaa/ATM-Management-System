using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Management_System
{
    public partial class MiniStatement : Form
    {
        public MiniStatement()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yannb\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;
        private void populate() 
        {
            Con.Open();
            string query = "Select * From TransactionTbl Where AccNum='" + Acc + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGVMiniStatement.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void MiniStatement_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void lblLogoutFastCash_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
