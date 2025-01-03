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
    public partial class Presence_Absence : Form
    {

        public Presence_Absence()
        {
            InitializeComponent();
            
        }
        OleDbConnection con;
        OleDbCommand com;
        OleDbDataAdapter adapter;
        DataTable dt;
        private void button1_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source = DataBase90.accdb");
            adapter = new OleDbDataAdapter("SELECT * FROM users", con);

            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
        }
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

                    txtsaturday.Text = selectedRow.Cells[6].Value?.ToString() ?? "";
                    txtsunday.Text = selectedRow.Cells[7].Value?.ToString() ?? "";
                    txtmonday.Text = selectedRow.Cells[8].Value?.ToString() ?? "";
                    txttuesday.Text = selectedRow.Cells[9].Value?.ToString() ?? "";
                    txtwednesday.Text = selectedRow.Cells[10].Value?.ToString() ?? "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در دریافت اطلاعات سطر");
                }

            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

           if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    dataGridView1.CurrentRow.Cells[6].Value = txtsaturday.Text;
                    dataGridView1.CurrentRow.Cells[7].Value = txtsunday.Text;
                    dataGridView1.CurrentRow.Cells[8].Value = txtmonday.Text;
                    dataGridView1.CurrentRow.Cells[9].Value = txttuesday.Text;
                    dataGridView1.CurrentRow.Cells[10].Value = txtwednesday.Text;

                    string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source= DataBase90.accdb;";
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        string query = "UPDATE users SET [saturday] = @saturday,[sunday] = @sunday,[monday] = @monday,[tuesday] = @tuesday,[wednesday] = @wednesday WHERE ID = @ID";

                        using (OleDbCommand com = new OleDbCommand(query,con))
                        {
                            com.Parameters.AddWithValue("@saturday", txtsaturday.Text);
                            com.Parameters.AddWithValue("@sunday", txtsunday.Text);
                            com.Parameters.AddWithValue("@monday", txtmonday.Text);
                            com.Parameters.AddWithValue("@tuesday", txttuesday.Text);
                            com.Parameters.AddWithValue("@wednesday", txtwednesday.Text);
                            com.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
                            con.Open();
                            int rowAffected = com.ExecuteNonQuery(); 
                            if (rowAffected > 0)
                            {
                                MessageBox.Show("حضور و غیاب با موفقیت انجام شد");
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
                    MessageBox.Show("در انجام حضور و غیاب مشکلی پیش آمد");
                }
            }
            else
            {
                MessageBox.Show("خطا : لطفا یک سطر را انتخاب کنید");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
        }
    }
}
