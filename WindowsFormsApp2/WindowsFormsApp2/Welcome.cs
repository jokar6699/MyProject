using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace School
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void دربارهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info info = new info(); 
            this.Hide();
            info.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();  
            this.Hide();
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
