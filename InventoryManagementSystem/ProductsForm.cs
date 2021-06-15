using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ProductsForm : Form
    {
        private static string connection = "Data Source=192.168.0.31;Initial Catalog=finalDB;Persist Security Info=True;User ID=SA;Password=password1";
        private string sqlQuery;
        private int selectedCategoryId;
        private int selectedRowId;

        SqlConnection sqlConnection = new SqlConnection(connection);
        SqlCommand sqlCommand;
        public ProductsForm()
        {
            InitializeComponent();
            dgvProducts.ReadOnly = true;
        }
        void populate()
        {
            try
            {
                sqlQuery = "SELECT products.id As 'ID', products.name As 'Name', products.price As 'Price', products.description As 'Description',products.quantity As 'Quantity',categories.name As 'Category' " +
                    "FROM products " +
                    "JOIN categories ON categories.id = products.categoryId ORDER BY products.id ";
                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                var dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dgvProducts.DataSource = dataSet.Tables[0];
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
            selectedCategoryId = Int32.Parse(cbCategory.SelectedValue.ToString());
            // check category name validation
            try
            {
                sqlQuery = "INSERT INTO products VALUES(@name,@price,@quantity,@description,@category);";
                sqlConnection.Open();

                sqlCommand = new SqlCommand(sqlQuery, sqlConnection); // execute sql command with connection and parameters
                sqlCommand.Parameters.AddWithValue("name", tbName.Text.ToString());
                sqlCommand.Parameters.AddWithValue("price", float.Parse(tbPrice.Text.ToString()));
                sqlCommand.Parameters.AddWithValue("quantity", float.Parse(tbQuantity.Text.ToString()));
                sqlCommand.Parameters.AddWithValue("description", tbDescription.Text.ToString());
                sqlCommand.Parameters.AddWithValue("category", selectedCategoryId);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Product added");

                populate();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }

      

        private void btnEdit_Click(object sender, EventArgs e)
        {
            selectedCategoryId = Int32.Parse(cbCategory.SelectedValue.ToString());
            selectedRowId = Int32.Parse(dgvProducts.SelectedRows[0].Cells["ID"].Value.ToString());
            Console.WriteLine(selectedRowId);
            try
            {
                sqlQuery = "UPDATE products SET name = (@name), price = (@price), quantity = (@quantity), description = (@description), categoryId = (@category) where id = "+ selectedRowId + ";";
                sqlConnection.Open();

                sqlCommand = new SqlCommand(sqlQuery, sqlConnection); // execute sql command with connection and parameters
                sqlCommand.Parameters.AddWithValue("name", tbName.Text.ToString());
                sqlCommand.Parameters.AddWithValue("price", float.Parse(tbPrice.Text.ToString()));
                sqlCommand.Parameters.AddWithValue("quantity", float.Parse(tbQuantity.Text.ToString()));
                sqlCommand.Parameters.AddWithValue("description", tbDescription.Text.ToString());
                sqlCommand.Parameters.AddWithValue("category", selectedCategoryId);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Product updated");

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
            selectedRowId = Int32.Parse(dgvProducts.SelectedRows[0].Cells["ID"].Value.ToString());

            try
            {
                sqlQuery = "DELETE FROM products WHERE id = (@id);";
                sqlConnection.Open();

                sqlCommand = new SqlCommand(sqlQuery, sqlConnection); // execute sql command with connection and parameters
                sqlCommand.Parameters.AddWithValue("id", selectedRowId);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Product deleted");

                populate();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductsForm_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDBDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.finalDBDataSet.products);
            // TODO: This line of code loads data into the 'finalDBDataSet.categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.finalDBDataSet.categories);
            populate();

        }

      
    }
}
