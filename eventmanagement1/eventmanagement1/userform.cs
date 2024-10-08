using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventmanagement1
{
    public partial class userform : Form
    {
        public userform()
        {
            InitializeComponent();
        }

        private void myApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            application form10 = new application();
            form10.Show();
        }

        private void showApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            applicationshow form10 = new applicationshow();
            form10.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            userform h = new userform();
            h.Show();
        }
    }
}
