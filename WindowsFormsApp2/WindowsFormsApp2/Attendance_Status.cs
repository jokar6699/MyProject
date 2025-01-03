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

namespace School
{
    public partial class Attendance_Status : Form
    {
        public Attendance_Status()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_Profile form2 = new User_Profile();
            this.Hide();
            form2.ShowDialog();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;Data Source=DataBase90.accdb";
            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.CommandText = "SELECT * FROM [users] WHERE [uname]=?";
            com.Parameters.AddWithValue("@uname", School.Properties.Settings.Default.userlog);
            com.Connection = con;
            OleDbDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                lbshande.Text = reader["saturday"].ToString();
                lb1shanbe.Text = reader["sunday"].ToString();
                lb2shanbe.Text = reader["monday"].ToString();
                lb3shanbe.Text = reader["tuesday"].ToString();
                lb4shanbe.Text = reader["wednesday"].ToString();

            }
            else
            {
                MessageBox.Show("خطای نامشخص");
            }


        }
    }
}
