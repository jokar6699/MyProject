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
using WindowsFormsApp2;

namespace School
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbCommand com;
        OleDbDataAdapter adapter;
        DataTable dt;
        int selected_index;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string str = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            selected_index = Convert.ToInt32(str);

            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                    txtmath.Text = selectedRow.Cells[11].Value?.ToString() ?? "";
                    txtscience.Text = selectedRow.Cells[12].Value?.ToString() ?? "";
                    txtpersian.Text = selectedRow.Cells[13].Value?.ToString() ?? "";
                    txtritual.Text = selectedRow.Cells[14].Value?.ToString() ?? "";
                    txtexercise.Text = selectedRow.Cells[15].Value?.ToString() ?? "";
                    txtgeography.Text = selectedRow.Cells[16].Value?.ToString() ?? "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در دریافت اطلاعات سطر");
                }

            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source = DataBace90.accdb");
            adapter = new OleDbDataAdapter("SELECT * FROM users", con);

            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    dataGridView1.CurrentRow.Cells[11].Value = txtmath.Text;
                    dataGridView1.CurrentRow.Cells[12].Value = txtscience.Text;
                    dataGridView1.CurrentRow.Cells[13].Value = txtpersian.Text;
                    dataGridView1.CurrentRow.Cells[14].Value = txtritual.Text;
                    dataGridView1.CurrentRow.Cells[15].Value = txtexercise.Text;
                    dataGridView1.CurrentRow.Cells[16].Value = txtgeography.Text;

                    string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source= DataBace90.accdb;";
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        string query = "UPDATE users SET [math] = @math,[science] = @science,[persian] = @persian,[ritual] = @ritual,[exercise] = exercise ,[geography] = @geography WHERE ID = @ID";

                        using (OleDbCommand com = new OleDbCommand(query, con))
                        {
                            com.Parameters.AddWithValue("@math", txtmath.Text);
                            com.Parameters.AddWithValue("@science", txtscience.Text);
                            com.Parameters.AddWithValue("@persian", txtpersian.Text);
                            com.Parameters.AddWithValue("@ritual", txtritual.Text);
                            com.Parameters.AddWithValue("@exercise", txtexercise.Text);
                            com.Parameters.AddWithValue("@geography", txtgeography.Text);
                            com.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
                            con.Open();
                            int rowAffected = com.ExecuteNonQuery();
                            if (rowAffected > 0)
                            {
                                MessageBox.Show("نمرات با موفقیت ثبت شد");
                            }
                            else
                            {
                                MessageBox.Show("در ذخیره اطلاعات خطایی وجود دارد");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("در ثبت نمرات مشکلی پیش آمد");
                }
            }
            else
            {
                MessageBox.Show("خطا : لطفا یک سطر را انتخاب کنید");
            }
        }
    }
}
