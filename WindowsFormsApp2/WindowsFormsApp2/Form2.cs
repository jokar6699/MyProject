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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp2;

namespace School
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string usernname)
        {
            InitializeComponent();


        }

        private void Form2_Load(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;Data Source=DataBace90.accdb";
            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.CommandText = "SELECT * FROM [users] WHERE [uname]=?";
            com.Parameters.AddWithValue("@uname", School.Properties.Settings.Default.userlog);
            com.Connection = con;
            OleDbDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                lbname.Text = reader["name"].ToString();
                lbpaye.Text = reader["base0"].ToString();
                lbphone.Text = reader["phone_number"].ToString();
                lbuname.Text = reader["uname"].ToString();
                
            }
            else
            {
                MessageBox.Show("خطای نامشخص");
            }
        }
    }
}
