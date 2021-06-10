using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        private string connection = "Data Source=192.168.0.31;Initial Catalog=finalDB;Persist Security Info=True;User ID=SA;Password=password1";
        private string sql = "INSERT INTO Users VALUES (@username,@password)";

        SqlConnection sqlConnection;
        SqlCommand sqlCommand;

        public LoginForm()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true; // hide password field

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // changing visibility according to checkbox status
            if (cbShowPassword.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void lbClearAll_Click(object sender, EventArgs e)
        {
            tbUserName.Text = ""; // clear datas from textboxes
            tbPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // username and password validation
            if (tbUserName.Text.ToString().Length < 3 || tbPassword.Text.ToString().Length < 3)
            {
                MessageBox.Show("User name and password length should be longer than 3");
            }
            else
            {
                try
                {
                    sqlConnection = new SqlConnection(connection); // create and open connection
                    sqlConnection.Open();

                    sqlCommand = new SqlCommand(sql, sqlConnection); // execute sql command with connection and parameters
                    sqlCommand.Parameters.AddWithValue("username", tbUserName.Text.ToString());
                    sqlCommand.Parameters.AddWithValue("password", tbPassword.Text.ToString());

                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();
                    MessageBox.Show("User added");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            // hide this form and open main form
        }
    }
}
