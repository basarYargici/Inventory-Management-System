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
        private string customerType = "CUSTOMER";
        private int customerTypeInt = 3;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        User user;

        public LoginForm()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true; // hide password field

        }
        private void lbExit_Click(object sender, EventArgs e)
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
            tbMail.Text = ""; // clear datas from textboxes
            tbPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (login())
            {
                this.Hide();
                new MainForm(user)
                {
                    Location = Location,
                    Size = Size,
                    StartPosition = StartPosition
                }.ShowDialog();
                this.Close();
            }
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
                MessageBox.Show("Welcome back " + tbMail.Text.ToString() + "!");
                return true;
            }
            else
            {
                MessageBox.Show("Mail or password is wrong!");
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
                        MessageBox.Show(tbMail.Text.ToString() + " mail has already an account!");
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
                sqlQuery = "SELECT COUNT(*) FROM Users WHERE mail = '" + tbMail.Text.ToString() + "';";

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
                sqlQuery = "INSERT INTO users VALUES (@mail,@password," + customerTypeInt + ");" +
                    "INSERT INTO customers VALUES (@mail,0);";

                sqlConnection = new SqlConnection(connection); // create new connection and open it
                sqlConnection.Open();

                sqlCommand = new SqlCommand(sqlQuery, sqlConnection); // execute sql command with connection and parameters
                sqlCommand.Parameters.AddWithValue("mail", tbMail.Text.ToString());
                sqlCommand.Parameters.AddWithValue("password", tbPassword.Text.ToString());

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
                user = new User(tbMail.Text.ToString(), tbPassword.Text.ToString(), customerType);
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
                    //sqlQuery = "SELECT name,password FROM Users WHERE name = '" + tbMail.Text.ToString() + "';";
                    sqlQuery = "SELECT mail,password,type FROM users JOIN user_types ON user_types.id = users.FK_user_type WHERE mail = '" + tbMail.Text.ToString() + "';";

                    sqlConnection = new SqlConnection(connection); // create new connection and open it
                    sqlConnection.Open();

                    //sqlCommand = new SqlCommand(sqlQuery, sqlConnection); // execute sql command with connection and parameters

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlConnection);
                    DataTable dataTable = new DataTable();

                    sqlDataAdapter.Fill(dataTable);
                    DataRow rw = dataTable.AsEnumerable().FirstOrDefault(row => row.Field<String>("mail") == tbMail.Text.ToString());
                    //Console.WriteLine("LOG: " + rw.Field<string>("name") + ", " + rw.Field<string>("password"));

                    if (rw.Field<string>("mail").Equals(tbMail.Text.ToString()) && rw.Field<string>("password").Equals(tbPassword.Text.ToString()))
                    {
                        var type = rw.Field<string>("type");
                        user = new User(tbMail.Text.ToString(), tbPassword.Text.ToString(), type);
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
            if (tbMail.Text.ToString().Length < 3 || tbPassword.Text.ToString().Length < 3)
            {
                MessageBox.Show("User mail and password length should be longer than 3");
                return false;
            }
            return true;
        }


    }
}
