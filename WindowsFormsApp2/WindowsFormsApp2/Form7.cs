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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "provider=Microsoft.ace.oledb.12.0;data source = DataBace90.accdb";
            con.Open();

            OleDbCommand com = new OleDbCommand();
            com.CommandText = "DELETE FROM users WHERE ID = ?";
            com.Parameters.AddWithValue("@ID", txtid.Text);
            com.Connection = con;
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("دانش آموز انتخابی با موفقیت حذف شد");

            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
