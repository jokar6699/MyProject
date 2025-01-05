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
using School;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textpassword.Text != "" && textname.Text != "") // اگر مقادیر خالی نبود
            {
                if (checkBox1.Checked) // چک باکس تایید شده بود
                {
                    OleDbConnection con = new OleDbConnection(); // ارتباط با پایگاه داده
                    con.ConnectionString = "provider=Microsoft.ace.oledb.12.0;data source = DataBase90.accdb"; // مسیر پایگاه داده
                    con.Open();
                    OleDbCommand com = new OleDbCommand(); // رتباط با جدول پایگاه داده
                    com.CommandText = "SELECT COUNT(*) FROM [users] WHERE uname =? AND user_password=?";
                    com.Parameters.AddWithValue("@uname",textname.Text);
                    com.Parameters.AddWithValue("@user_password",textpassword.Text);
                    com.Connection = con;
                    int count = (int)com.ExecuteScalar();
                    if (count == 1) // اگر اطلاعات در پایگاه داده موجود بود
                    {
                        School.Properties.Settings.Default.logined = true;
                        School.Properties.Settings.Default.Save();
                        School.Properties.Settings.Default.userlog = textname.Text;
                        School.Properties.Settings.Default.Save();


                        User_Profile form2 = new User_Profile();
                        this.Hide();
                        form2.ShowDialog();
                        con.Close();
                    }
                    else if (textname.Text == "admin" && textpassword.Text == "123456")
                    {
                        Form4 form4 = new Form4();
                        this.Hide();
                        form4.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("نام کاربری یافت نشد");
                    }
                    
                }
                else
                {
                    MessageBox.Show("در چک باکس تایید کنید که ربات نیستید ");
                }
            }
            else if (textpassword.Text != "" && textname.Text == "")
            {
                MessageBox.Show("لظفا نام کاربری خود را وارد کنید");
            }
            else if (textpassword.Text == "" && textname.Text != "")
            {
                MessageBox.Show("لظفا رمزعبور خود را وارد نمایید ");
            }
            else
            {
                MessageBox.Show("لظفا اطلاعات خود را تکمیل کنید ");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_Up form3 = new Sign_Up();
            this.Hide();
            form3.ShowDialog();
        }

        private void textBox1_LocationChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MaximizeBox = false;
            textpassword.PasswordChar = '*'; // مخفی کردن پسورد
            textname.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
