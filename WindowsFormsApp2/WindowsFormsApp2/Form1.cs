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
    public partial class Form1 : Form
    {
        public Form1()
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
            if (textpassword.Text != "" && textname.Text != "")
            {
                if (checkBox1.Checked)
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = "provider=Microsoft.ace.oledb.12.0;data source = DataBace90.accdb";
                    con.Open();
                    OleDbCommand com = new OleDbCommand();
                    com.CommandText = "SELECT COUNT(*) FROM [person] WHERE uname =? AND password=?";
                    com.Parameters.AddWithValue("@uname",textname.Text);
                    com.Parameters.AddWithValue("@password",textpassword.Text);
                    com.Connection = con;
                    int count = (int)com.ExecuteScalar();
                    if (count == 1)
                    {



                        Form2 form2 = new Form2();
                        this.Hide();
                        form2.ShowDialog();
                        con.Close();
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
            Form3 form3 = new Form3();
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

        }
    }
}
