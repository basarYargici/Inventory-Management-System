using InventoryManagementSystem.Entities;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class CustomerProductsForm : Form
    {
        private ProductsHelper productsHelper;
        User user;
        private int piece;
        String now;
        private float bill;
        public CustomerProductsForm(User user)
        {
            this.user = user;
            InitializeComponent();
            productsHelper = new ProductsHelper();
            productsHelper.SqlConnection = new SqlConnection(productsHelper.Connection);
            dgvProducts.ReadOnly = true;
            tbName.ReadOnly = true;
            tbDescription.ReadOnly = true;
            tbPrice.ReadOnly = true;
            cbCategory.Enabled = false;
        }

        // Set the text of labels as selected row datas
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productsHelper.changeCustomerLabels(dgvProducts, tbName, tbPrice, tbDescription, cbCategory);
            cbPiece.Items.Clear();
            getBill(user);

            for (int i = 1; i <= productsHelper.SelectedRowQuantity; i++)
            {
                cbPiece.Items.Add(i);
            }
            cbPiece.SelectedIndex = 0;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                now = DateTime.Now.ToString("u");
                productsHelper.SelectedRowId = Int32.Parse(dgvProducts.SelectedRows[0].Cells["ID"].Value.ToString());
                productsHelper.SelectedRowPrice = float.Parse(dgvProducts.SelectedRows[0].Cells["Price"].Value.ToString());
                piece = Int32.Parse(cbPiece.SelectedItem.ToString());
                productsHelper.SqlQuery = "INSERT INTO customers_products VALUES (@mail,@product_id," + piece + ",'"+ now + "');";
                                           //INSERT INTO customers_products VALUES('ccc',2,1,'2008-06-15 21:15:07Z')
                productsHelper.SqlConnection.Open();

                productsHelper.SqlCommand = new SqlCommand(productsHelper.SqlQuery, productsHelper.SqlConnection); // execute sql command with connection and parameters
                productsHelper.SqlCommand.Parameters.AddWithValue("mail", user.Mail);
                productsHelper.SqlCommand.Parameters.AddWithValue("product_id", productsHelper.SelectedRowId);

                productsHelper.SqlCommand.ExecuteNonQuery();
                productsHelper.SqlConnection.Close();

                bill += (productsHelper.SelectedRowPrice * piece);
                Console.WriteLine("bill: " + bill);
                Console.WriteLine("piece: " + piece);

                setBill(bill);
                MessageBox.Show("The product has been purchased!");

                productsHelper.populate(productsHelper.SqlConnection, dgvProducts);
            }
            catch (Exception ex)
            {
                productsHelper.SqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void CustomerProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDBDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.finalDBDataSet.products);
            // TODO: This line of code loads data into the 'finalDBDataSet.categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.finalDBDataSet.categories);
            productsHelper.populate(productsHelper.SqlConnection, dgvProducts);
            productsHelper.changeCustomerLabels(dgvProducts, tbName, tbPrice, tbDescription, cbCategory);

        }

        private float getBill(User user)
        {
            try
            {
                productsHelper.SqlQuery = "SELECT customers.mail AS 'Mail', customers.bill AS 'Bill' FROM customers " +
                    "JOIN users ON customers.mail = users.mail WHERE customers.mail = '" + user.Mail + "';";

                productsHelper.SqlConnection.Open();

                productsHelper.SqlCommand = new SqlCommand(productsHelper.SqlQuery, productsHelper.SqlConnection); // execute sql command with connection and parameters

                SqlDataReader reader = productsHelper.SqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    bill = float.Parse(reader[1].ToString());
                }
                // Console.WriteLine(bill);

                productsHelper.SqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return bill;
        }

        private void setBill(float bill)
        {
            try
            {
                productsHelper.SqlQuery = "UPDATE customers SET bill =" + bill + " WHERE customers.mail = '" + user.Mail + "';";

                productsHelper.SqlConnection.Open();

                productsHelper.SqlCommand = new SqlCommand(productsHelper.SqlQuery, productsHelper.SqlConnection); // execute sql command with connection and parameters

                productsHelper.SqlCommand.ExecuteNonQuery();
                // Console.WriteLine(bill);

                productsHelper.SqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
