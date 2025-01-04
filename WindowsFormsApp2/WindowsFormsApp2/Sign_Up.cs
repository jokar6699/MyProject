using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            txtpassword.PasswordChar = '*';
            txtrepassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("لطفا نام خود را وارد نمایید");
            }
            else if (txtuname.Text == "")
            {
                MessageBox.Show("لطفا نام کاربری خود را وارد نمایید");

            }
            else if (txtpaye.Text == "")
            {
                MessageBox.Show("لطفا پایه تحصیلی خود را وارد نمایید");

            }
            else if (txtnumber.Text == "")
            {
                MessageBox.Show("لطفا شماره تماس خود را وارد کنید");

            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("لطفا رمز عبور خود را وارد کنید");
            }
            else if (txtrepassword.Text == "")
            {
                MessageBox.Show("لطفا رمز عبور خود را تکرار کنید");
            }
            else if (!checkBox1.Checked)
            {
                MessageBox.Show("در چک باکس تایید کنید که ربات نیستید");
            }
            else if (txtrepassword.Text != txtpassword.Text)
            {
                MessageBox.Show("رمز های عبور باهم مطابقت ندارند");
            }
            else
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;Data Source=DataBase90.accdb";
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM [users] WHERE [uname]=?";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@uname", txtuname.Text);
                int count = (int)cmd.ExecuteScalar();
                if (count == 1)
                {
                    con.Close();

                    MessageBox.Show("نام کاربری در حال حاضر وجود دارد");

                }
                else
                {
                    con.Close();
                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = "provider=Microsoft.ace.oledb.12.0;data source = DataBase90.accdb";
                    conn.Open();

                    OleDbCommand com = new OleDbCommand();
                    com.CommandText = "insert into [users]([name],[uname],[phone_number],[base0],[user_password]) values(?,?,?,?,?)";
                    com.Parameters.AddWithValue("@name", txtname.Text);
                    com.Parameters.AddWithValue("@uname", txtuname.Text);
                    com.Parameters.AddWithValue("@phone_number", txtnumber.Text);
                    com.Parameters.AddWithValue("@base0", txtpaye.Text);
                    com.Parameters.AddWithValue("@user_password", txtpassword.Text);
                    com.Connection = conn;
                    com.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("ثبت نام با موفقیت انجام شد");


                    Login form1 = new Login();
                    this.Hide();
                    form1.ShowDialog();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            this.Hide();
            form1.ShowDialog();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
