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
    
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=SDSALAB\SQLEXPRESS;Initial Catalog=eventrishan;Integrated Security=True");
        SqlCommand cmd;
        string gender;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform form2 = new loginform();
            form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                conn.Open();
                cmd = new SqlCommand("INSERT INTO register VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + gender + "','" + textBox4.Text + "','" + textBox5.Text + "','user')",conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("inserted succesfully");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text ="";
            textBox2.Text ="";
            textBox3.Text ="";
            textBox4.Text ="";
            textBox5.Text ="";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }
    }
}
