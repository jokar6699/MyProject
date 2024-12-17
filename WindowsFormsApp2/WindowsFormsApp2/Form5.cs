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

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
            MessageBox.Show("دانش آموز جدید با موفقیت ثبت شد");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
        }
    }
}
