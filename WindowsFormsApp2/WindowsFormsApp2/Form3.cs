﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtname.Text != "" && txtuname.Text != "" && txtnumber.Text != "" && txtemail.Text != "" && txtpassword.Text != "" && txtrepassword.Text != "") 
            {

                if (txtpassword.Text == txtrepassword.Text)
                {
                    if (checkBox1.Checked)
                    {
                        OleDbConnection con = new OleDbConnection();
                        con.ConnectionString = "provider=Microsoft.ace.oledb.12.0;data source = DataBace90.accdb";
                        con.Open();

                        OleDbCommand com = new OleDbCommand();
                        com.CommandText = "insert into [person]([name],[uname],[number],[email],[password]) values(?,?,?,?,?)";
                        com.Parameters.AddWithValue("@name", txtname.Text);
                        com.Parameters.AddWithValue("@uname", txtuname.Text);
                        com.Parameters.AddWithValue("@number", txtnumber.Text);
                        com.Parameters.AddWithValue("@email", txtemail.Text);
                        com.Parameters.AddWithValue("@password", txtpassword.Text);
                        com.Connection = con;
                        com.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("sabt shod");


                        Form1 form1 = new Form1();
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
            Form1 form1 = new Form1();
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
