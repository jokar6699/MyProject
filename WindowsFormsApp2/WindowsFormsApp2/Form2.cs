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
                //اطلاعات شخصی
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            this.Hide();
            form9.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();   
            this.Hide();
            form10.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هشدار:اطلاعات قابل بازیابی نخواهند بود", "آیا مطمین هستید؟؟؟", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;Data Source=DataBace90.accdb";
                con.Open();
                OleDbCommand com = new OleDbCommand();
                com.CommandText = "delete from [users] where [uname]=?";
                string username = School.Properties.Settings.Default.userlog.ToString();
                com.Parameters.AddWithValue("@uname", username);
                com.Connection = con;
                int count = (int)com.ExecuteNonQuery();
                if (count == 1)
                {
                    con.Close();

                    MessageBox.Show("حساب کاربری با موفقیت از سیستم حذف شد");
                    School.Properties.Settings.Default.userlog = null;
                    School.Properties.Settings.Default.Save();
                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.Show();

                }
                else
                {

                    con.Close();

                    MessageBox.Show("در حذف حساب کاربری خطایی وجود دارد");
                }
            }
        }
    }
}
