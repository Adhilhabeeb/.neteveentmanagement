using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace eventmanagement1
{
    public partial class application : Form
    {
        string events;
        public application()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Database = @"Data Source = SDSALAB\SQLEXPRESS; Initial Catalog = eventrishan; Integrated Security = True";

            SqlConnection connect = new SqlConnection(Database);

            connect.Open();
            
            String query = "INSERT INTO application VALUES ('" + appname.Text + "','" + depname.Text + "','"+events+"','" + date.Text + "','" + status.Text + "') ";

            SqlCommand cmd = new SqlCommand(query,connect);
            cmd.ExecuteNonQuery();

            connect.Close();

            MessageBox.Show("Succesfully inserted");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            events = "music";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            events = "food";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            events = "dance";
        }

        private void application_Load(object sender, EventArgs e)
        {

        }
    }
}
