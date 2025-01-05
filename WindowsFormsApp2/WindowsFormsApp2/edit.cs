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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace School
{
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
        }

        private void edit_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(); // ارتباط با پایگاه داده
            con.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;Data Source=DataBase90.accdb";
            con.Open();
            OleDbCommand com = new OleDbCommand(); // ارتباط با جدول 
            com.CommandText = "SELECT * FROM [users] WHERE [uname]=?";
            com.Parameters.AddWithValue("@uname", School.Properties.Settings.Default.userlog);
            com.Connection = con;
            OleDbDataReader reader = com.ExecuteReader(); // خواندن اطلاعات از پایگاه داده
            if (reader.Read())
            {
                // نمایش اطلاعات در تکست باکس یا لیبل
                label6.Text = reader["name"].ToString();
                textBox4.Text = reader["base0"].ToString();
                textBox2.Text = reader["phone_number"].ToString();
                textBox1.Text = reader["uname"].ToString();
                textBox3.Text = reader["user_password"].ToString();



            }
            else
            {
                MessageBox.Show("خطای نامشخص");
            }
        }

        private void vorod_Click(object sender, EventArgs e)
        {
            string username = School.Properties.Settings.Default.userlog;
            OleDbConnection con = new OleDbConnection(); // ارتباط با پایگاه 
            con.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;Data Source=DataBase90.accdb";
            con.Open();
            OleDbCommand com = new OleDbCommand(); // ارتباط با جدول
            com.CommandText = "Update [users] set [uname]=?,[base0]=?, [phone_number]=? ,[user_password]=? WHERE [uname]=? "; // بروزرسانی
            com.Connection = con;
            // اجرا در ستون های انتخابی جدول پایگاه داده
            com.Parameters.AddWithValue("@uname", textBox1.Text);
            com.Parameters.AddWithValue("@base0", textBox4.Text);
            com.Parameters.AddWithValue("@phone_number", textBox2.Text);
            com.Parameters.AddWithValue("@user_password", textBox3.Text);
            com.Parameters.AddWithValue("@uname", username);
            int raw = (int)com.ExecuteNonQuery();
            con.Close();

            if (raw > 0)
            {
                School.Properties.Settings.Default.userlog = textBox1.Text;
                School.Properties.Settings.Default.Save();
                MessageBox.Show("اطلاعات با موفقیت بروزرسانی شد");


            }
            else
            {
                MessageBox.Show("در بروزرسانی اطلاعات خطایی وجود دارد");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Profile user_Profile = new User_Profile(); 
            this.Hide();
            user_Profile.ShowDialog();
        }
    }
}
