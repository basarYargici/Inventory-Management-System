using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class NonCustomerProductsForm : Form
    {
        private ProductsHelper productsHelper;

        public NonCustomerProductsForm()
        {
            InitializeComponent();

            productsHelper = new ProductsHelper();
            productsHelper.SqlConnection = new SqlConnection(productsHelper.Connection);

            dgvProducts.ReadOnly = true;
        }



        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            productsHelper.SelectedCategoryId = Int32.Parse(cbCategory.SelectedValue.ToString());
            // check category name validation
            try
            {
                productsHelper.SqlQuery = "INSERT INTO products VALUES(@name,@price,@quantity,@description,@category);";
                productsHelper.SqlConnection.Open();

                productsHelper.SqlCommand = new SqlCommand(productsHelper.SqlQuery, productsHelper.SqlConnection); // execute sql command with connection and parameters
                productsHelper.SqlCommand.Parameters.AddWithValue("name", tbName.Text.ToString());
                productsHelper.SqlCommand.Parameters.AddWithValue("price", float.Parse(tbPrice.Text.ToString()));
                productsHelper.SqlCommand.Parameters.AddWithValue("quantity", Int32.Parse(tbQuantity.Text.ToString()));
                productsHelper.SqlCommand.Parameters.AddWithValue("description", tbDescription.Text.ToString());
                productsHelper.SqlCommand.Parameters.AddWithValue("category", productsHelper.SelectedCategoryId);

                productsHelper.SqlCommand.ExecuteNonQuery();
                productsHelper.SqlConnection.Close();
                MessageBox.Show("Product added");

                productsHelper.populate(productsHelper.SqlConnection, dgvProducts);
            }
            catch (Exception ex)
            {
                productsHelper.SqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            productsHelper.SelectedCategoryId = Int32.Parse(cbCategory.SelectedValue.ToString());
            productsHelper.SelectedRowId = Int32.Parse(dgvProducts.SelectedRows[0].Cells["ID"].Value.ToString());

            try
            {
                productsHelper.SqlQuery = "UPDATE products SET name = (@name), price = (@price), quantity = (@quantity), description = (@description), categoryId = (@category) where id = " + productsHelper.SelectedRowId + ";";
                productsHelper.SqlConnection.Open();

                productsHelper.SqlCommand = new SqlCommand(productsHelper.SqlQuery, productsHelper.SqlConnection); // execute sql command with connection and parameters
                productsHelper.SqlCommand.Parameters.AddWithValue("name", tbName.Text.ToString());
                productsHelper.SqlCommand.Parameters.AddWithValue("price", float.Parse(tbPrice.Text.ToString()));
                productsHelper.SqlCommand.Parameters.AddWithValue("quantity", Int32.Parse(tbQuantity.Text.ToString()));
                productsHelper.SqlCommand.Parameters.AddWithValue("description", tbDescription.Text.ToString());
                productsHelper.SqlCommand.Parameters.AddWithValue("category", productsHelper.SelectedCategoryId);

                productsHelper.SqlCommand.ExecuteNonQuery();
                productsHelper.SqlConnection.Close();
                MessageBox.Show("Product updated");

                productsHelper.populate(productsHelper.SqlConnection, dgvProducts);
            }
            catch (Exception ex)
            {
                productsHelper.SqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            productsHelper.SelectedRowId = Int32.Parse(dgvProducts.SelectedRows[0].Cells["ID"].Value.ToString());
            try
            {
                productsHelper.SqlQuery = "DELETE FROM products WHERE id = (@id);";
                productsHelper.SqlConnection.Open();

                productsHelper.SqlCommand = new SqlCommand(productsHelper.SqlQuery, productsHelper.SqlConnection); // execute sql command with connection and parameters
                productsHelper.SqlCommand.Parameters.AddWithValue("id", productsHelper.SelectedRowId);

                productsHelper.SqlCommand.ExecuteNonQuery();
                productsHelper.SqlConnection.Close();
                MessageBox.Show("Product deleted");

                productsHelper.populate(productsHelper.SqlConnection, dgvProducts);
            }
            catch (Exception ex)
            {
                productsHelper.SqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void NonCustomerProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDBDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.finalDBDataSet.products);
            // TODO: This line of code loads data into the 'finalDBDataSet.categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.finalDBDataSet.categories);
            productsHelper.populate(productsHelper.SqlConnection, dgvProducts);
            productsHelper.changeNonCustomerLabels(dgvProducts, tbName, tbPrice, tbQuantity, tbDescription, cbCategory);
        }

        // Set the text of labels as selected row datas
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productsHelper.changeNonCustomerLabels(dgvProducts, tbName, tbPrice, tbQuantity, tbDescription, cbCategory);
        }
    }
}
