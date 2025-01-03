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

            if (txtname.Text != "" && txtuname.Text != "" && txtnumber.Text != "" && txtpaye.Text != "" && txtpassword.Text != "" && txtrepassword.Text != "") 
            {

                if (txtpassword.Text == txtrepassword.Text)
                {
                    if (checkBox1.Checked)
                    {
                        OleDbConnection con = new OleDbConnection();
                        con.ConnectionString = "provider=Microsoft.ace.oledb.12.0;data source = DataBase90.accdb";
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
                        MessageBox.Show("ثبت نام با موفقیت انجام شد");


                        Login form1 = new Login();
                        this.Hide();
                        form1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("در چک باکس تایید کنید ربات نیستید");
                    }
                }
                else
                {
                    MessageBox.Show("رمز عبور با هم مطابقت ندارد");
                }
            }
            else
            {
                MessageBox.Show("لطفا اطلاعات را به درستی تکمیل کنید");
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
