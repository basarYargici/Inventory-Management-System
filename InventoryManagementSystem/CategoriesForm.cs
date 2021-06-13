using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class CategoriesForm : Form
    {
        private static string connection = "Data Source=192.168.0.31;Initial Catalog=finalDB;Persist Security Info=True;User ID=SA;Password=password1";
        private string sqlQuery;

        SqlConnection sqlConnection = new SqlConnection(connection); 
        SqlCommand sqlCommand;
        
        private int selectedRowId;

        public CategoriesForm()
        {
            InitializeComponent();
            dgvCustomers.ReadOnly = true;
        }

        void populate()
        {
            try
            {
                sqlQuery = "SELECT * FROM categories ORDER BY id;";
                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                var dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dgvCustomers.DataSource = dataSet.Tables[0];
                
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            // check category name validation
            try
            {
                sqlQuery = "INSERT INTO categories VALUES(@category);";
                sqlConnection.Open();

                sqlCommand = new SqlCommand(sqlQuery, sqlConnection); // execute sql command with connection and parameters
                sqlCommand.Parameters.AddWithValue("category", tbCategory.Text.ToString());

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            selectedRowId = Int32.Parse(dgvCustomers.SelectedRows[0].Cells["id"].Value.ToString());
            
            try
            {
                sqlQuery = "UPDATE categories SET name = (@category) where id = (@id);";
                sqlConnection.Open();

                sqlCommand = new SqlCommand(sqlQuery, sqlConnection); // execute sql command with connection and parameters
                sqlCommand.Parameters.AddWithValue("category", tbCategory.Text.ToString());
                sqlCommand.Parameters.AddWithValue("id", selectedRowId);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            selectedRowId = Int32.Parse(dgvCustomers.SelectedRows[0].Cells["id"].Value.ToString());
            
            try
            {
                sqlQuery = "DELETE FROM categories WHERE id = (@id);";
                sqlConnection.Open();

                sqlCommand = new SqlCommand(sqlQuery, sqlConnection); // execute sql command with connection and parameters
                sqlCommand.Parameters.AddWithValue("id", selectedRowId);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            populate();
        }


    }
}
