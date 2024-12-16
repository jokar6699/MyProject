using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbDataAdapter adapter;
        DataTable dt;
        private void button1_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source = DataBace90.accdb");
            adapter = new OleDbDataAdapter("SELECT * FROM users", con);
            
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(adapter);
            adapter.Update(dt);
            MessageBox.Show("با موفقیت بروزرسانی شد");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "provider=Microsoft.ace.oledb.12.0;data source = DataBace90.accdb";
            con.Open();

            OleDbCommand com = new OleDbCommand();
            com.CommandText = "insert into [users]([name],[uname],[phone_number],[base0],[user_password]) values(?,?,?,?,?)";
            com.Parameters.AddWithValue("@name", txtname.Text);
            com.Parameters.AddWithValue("@uname", txtuname.Text);
            com.Parameters.AddWithValue("@phone_number", txtnumber.Text);
            com.Parameters.AddWithValue("@base0", txtpaye.Text);
            com.Parameters.AddWithValue("@user_password", txtpassword.Text);
            com.Connection = con;
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("با موفقیت ثبت شد");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
