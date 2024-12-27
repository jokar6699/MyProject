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
using School;
namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbCommand com;
        OleDbDataAdapter adapter;
        DataTable dt;
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

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(adapter);
                adapter.Update(dt);
                MessageBox.Show("با موفقیت بروزرسانی شد");
            }
            else
            {
                MessageBox.Show("هیچ تغییری در جدول رخ نداده");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        int selected_index;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string str = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            selected_index = Convert.ToInt32(str);
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
           Form7 form7 = new Form7();
            this.Hide();
            form7.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();  
            this.Hide(); form8.ShowDialog();    
        }
    }
}
