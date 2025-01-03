using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            this.Hide();
            welcome.ShowDialog();
        }

        private void info_Load(object sender, EventArgs e)
        {

        }
    }
}
