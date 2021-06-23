using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class EmployeesForm : Form
    {
        private string connection = "Data Source=192.168.0.31;Initial Catalog=finalDB;Persist Security Info=True;User ID=SA;Password=password1";
        private string sqlQuery;
        private int employeeTypeInt = 2;

        private string name;
        private string surname;
        private string password;
        private float salary;

        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        public EmployeesForm()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(connection);
            dgvEmployees.ReadOnly = true;
        }

        public void populate()
        {
            try
            {
                sqlQuery = "SELECT name As 'Name', surname As 'Surname', salary As 'Salary', employees.password As 'Password' FROM users " +
                    "JOIN employees ON employees.name = users.mail WHERE FK_user_type = " + employeeTypeInt + ";";
                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                var dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dgvEmployees.DataSource = dataSet.Tables[0];
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            try
            {
                sqlQuery = "INSERT INTO employees VALUES (@name,@surname,@salary,@password);" +
                    "INSERT INTO users VALUES (@name,@password," + employeeTypeInt + ");";


                sqlConnection.Open();

                sqlCommand = new SqlCommand(sqlQuery, sqlConnection); // execute sql command with connection and parameters
                sqlCommand.Parameters.AddWithValue("name", tbName.Text.ToString());
                sqlCommand.Parameters.AddWithValue("surname", tbSurname.Text.ToString());
                sqlCommand.Parameters.AddWithValue("salary", float.Parse(tbSalary.Text.ToString()));
                sqlCommand.Parameters.AddWithValue("password", tbPassword.Text.ToString());

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Employee added");

                populate();
            }

            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            populate();
            changeEmployeeLabels();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                sqlQuery = "UPDATE employees SET name = (@name), surname = (@surname), salary = (@salary), password = (@password) WHERE name = '" + name + "'" +
                    "UPDATE users SET mail = (@name), password = (@password) WHERE mail = '" + name + "'";


                sqlConnection.Open();

                sqlCommand = new SqlCommand(sqlQuery, sqlConnection); // execute sql command with connection and parameters
                sqlCommand.Parameters.AddWithValue("name", tbName.Text.ToString());
                sqlCommand.Parameters.AddWithValue("surname", tbSurname.Text.ToString());
                sqlCommand.Parameters.AddWithValue("salary", float.Parse(tbSalary.Text.ToString()));
                sqlCommand.Parameters.AddWithValue("password", tbPassword.Text.ToString());

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Employee Updated");

                populate();
            }

            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                sqlQuery = "DELETE FROM employees WHERE name = (@name);" +
                    "DELETE FROM users WHERE mail = (@name)";
                sqlConnection.Open();

                sqlCommand = new SqlCommand(sqlQuery, sqlConnection); // execute sql command with connection and parameters
                sqlCommand.Parameters.AddWithValue("name", name);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Employee deleted");

                populate();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void changeEmployeeLabels()
        {
            if (dgvEmployees.CurrentCell.RowIndex + 1 < dgvEmployees.RowCount)
            {
                name = dgvEmployees.SelectedRows[0].Cells["Name"].Value.ToString();
                surname = dgvEmployees.SelectedRows[0].Cells["Surname"].Value.ToString();
                salary = float.Parse(dgvEmployees.SelectedRows[0].Cells["Salary"].Value.ToString());
                password = dgvEmployees.SelectedRows[0].Cells["Password"].Value.ToString();

                tbName.Text = name;
                tbSurname.Text = surname;
                tbSalary.Text = salary.ToString();
                tbPassword.Text = password;
            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            changeEmployeeLabels();
        }


    }
}
