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
    public partial class User_Profile : Form
    {
        public User_Profile()
        {
            InitializeComponent();
        }
        public User_Profile(string usernname)
        {
            InitializeComponent();


        }

        private void Form2_Load(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection(); // ارتباط با پایگاه داده
            con.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;Data Source=DataBase90.accdb"; // مسیر پایگاه داده
            con.Open();
            OleDbCommand com = new OleDbCommand(); // ارتباط با جدول پایگاه داده
            com.CommandText = "SELECT * FROM [users] WHERE [uname]=?"; // دستور
            com.Parameters.AddWithValue("@uname", School.Properties.Settings.Default.userlog);
            com.Connection = con;
            OleDbDataReader reader = com.ExecuteReader(); // خواندن اطلاعات از پایگاه داده
            if (reader.Read()) // در صورت خواندن اطلاعات
            {
                // نمایش اطلاعات در لیبل ها
                lbname.Text = reader["name"].ToString();
                lbpaye.Text = reader["base0"].ToString();
                lbphone.Text = reader["phone_number"].ToString();
                lbuname.Text = reader["uname"].ToString();
       

            }
            else // در غیر این صورت
            {
                MessageBox.Show("خطای نامشخص");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Attendance_Status form9 = new Attendance_Status();
            this.Hide();
            form9.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scores form10 = new Scores();   
            this.Hide();
            form10.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            this.Hide();
            form1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // حذف حساب کاریری
            var result = MessageBox.Show("هشدار:اطلاعات قابل بازیابی نخواهند بود", "آیا مطمین هستید؟؟؟", MessageBoxButtons.YesNo); // پیغام اطمینان از حذف حساب 
            if (result == DialogResult.Yes)
            {
                OleDbConnection con = new OleDbConnection(); // ارتباط با پایگاه داده
                con.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;Data Source=DataBase90.accdb";
                con.Open();
                OleDbCommand com = new OleDbCommand(); // ارتباط با جدول پایگاه داده
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
                    Login form1 = new Login();
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

        private void button5_Click(object sender, EventArgs e)
        {
            edit edit = new edit(); 
            this.Hide();
            edit.ShowDialog();
        }
    }
}
