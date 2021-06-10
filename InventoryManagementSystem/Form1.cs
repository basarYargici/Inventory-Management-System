using InventoryManagementSystem.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        private string connection = "Data Source=192.168.0.31;Initial Catalog=finalDB;Persist Security Info=True;User ID=SA;Password=password1";
        private string sqlQuery;

        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        User user; 

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
            login();
            // close this form, go to next form with giving user as a parameter

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            signUp();
        }

        private Boolean login()
        {
            if (validateUser())
            {
                MessageBox.Show("Welcome back " + tbUserName.Text.ToString() + "!");
                return true;
            }
            else
            {
                MessageBox.Show("User name or password is wrong!");
            }
            return false;
        }

        private Boolean signUp()
        {

            if (validateInput())
            {
                try
                {
                    // if user exists
                    if (isUserExists())
                    {
                        MessageBox.Show(tbUserName.Text.ToString() + " username has already taken!");
                    }
                    else // if user not exists create new user
                    {
                        if (createUser())
                        {
                            MessageBox.Show("User added");
                        }
                        else
                        {
                            MessageBox.Show("User could not be added");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return true;
        }

        private Boolean isUserExists()
        {
            try
            {
                sqlQuery = "SELECT COUNT(*) FROM Users WHERE name = '" + tbUserName.Text.ToString() + "';";

                sqlConnection = new SqlConnection(connection); // create new connection and open it
                sqlConnection.Open();

                sqlCommand = new SqlCommand(sqlQuery, sqlConnection); // execute sql command with connection and parameters

                // if user exists
                if (sqlCommand.ExecuteScalar().ToString().Equals("1"))
                {
                    sqlConnection.Close();
                    return true;
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        private Boolean createUser()
        {
            try
            {
                sqlQuery = "INSERT INTO Users VALUES (@username,@password)";

                sqlConnection = new SqlConnection(connection); // create new connection and open it
                sqlConnection.Open();

                sqlCommand = new SqlCommand(sqlQuery, sqlConnection); // execute sql command with connection and parameters
                sqlCommand.Parameters.AddWithValue("username", tbUserName.Text.ToString());
                sqlCommand.Parameters.AddWithValue("password", tbPassword.Text.ToString());

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
                user = new User(tbUserName.Text.ToString(), tbPassword.Text.ToString());
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private Boolean validateUser()
        {
            if (isUserExists())
            {
                try
                {
                    sqlQuery = "SELECT name,password FROM Users WHERE name = '" + tbUserName.Text.ToString() + "';";

                    sqlConnection = new SqlConnection(connection); // create new connection and open it
                    sqlConnection.Open();

                    //sqlCommand = new SqlCommand(sqlQuery, sqlConnection); // execute sql command with connection and parameters

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlConnection);
                    DataTable dataTable = new DataTable();

                    sqlDataAdapter.Fill(dataTable);
                    DataRow rw = dataTable.AsEnumerable().FirstOrDefault(row => row.Field<String>("name") == tbUserName.Text.ToString());
                    Console.WriteLine("LOG: " + rw.Field<string>("name") + ", " + rw.Field<string>("password"));

                    if (rw.Field<string>("name").Equals(tbUserName.Text.ToString()) && rw.Field<string>("password").Equals(tbPassword.Text.ToString()))
                    {
                        user = new User(tbUserName.Text.ToString(), tbPassword.Text.ToString());
                        return true;
                    }
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                // close this form and go to next form
            }
            return false;

        }
        private Boolean validateInput()
        {
            // User name and password length should be longer than 3
            if (tbUserName.Text.ToString().Length < 3 || tbPassword.Text.ToString().Length < 3)
            {
                MessageBox.Show("User name and password length should be longer than 3");
                return false;
            }
            return true;
        }
    }
}
