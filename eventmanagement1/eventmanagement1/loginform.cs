using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace eventmanagement1
{
    public partial class loginform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=SDSALAB\SQLEXPRESS;Initial Catalog=eventrishan;Integrated Security=True");

        public loginform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                 
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM register WHERE email = @Email AND password = @Password", conn))
                {
                    cmd.Parameters.AddWithValue("@Email", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox2.Text);

                    int userCount = (int)cmd.ExecuteScalar();  

                    if (userCount == 1)
                    {
                         
                        using (SqlCommand userTypeCmd = new SqlCommand("SELECT usertype FROM register WHERE email = @Email", conn))
                        {
                            userTypeCmd.Parameters.AddWithValue("@Email", textBox1.Text);

                            string userType = userTypeCmd.ExecuteScalar()?.ToString(); // Get user type

                            if (userType == "user")
                            {
                                this.Hide();
                                userform form2 = new userform();
                                form2.Show();
                            }
                            else if (userType == "admin")
                            {
                                this.Hide();
                                adminform form2 = new adminform();
                                form2.Show();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); 
            }
            finally
            {
                conn.Close();  
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 r = new Form1();
            r.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';  
            }
            else
            {
                textBox2.PasswordChar = '*';  
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
