using Bunifu.UI.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    class ProductsHelper
    {
        private readonly string connection = "Data Source=192.168.0.31;Initial Catalog=finalDB;Persist Security Info=True;User ID=SA;Password=password1";
        private string sqlQuery;
        private int selectedCategoryId;
        private int selectedRowId;
        private string selectedRowName;
        private float selectedRowPrice;
        private int selectedRowQuantity;
        private string selectedRowDescription;
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;

        public string Connection { get => connection; }
        public string SqlQuery { get => sqlQuery; set => sqlQuery = value; }
        public int SelectedCategoryId { get => selectedCategoryId; set => selectedCategoryId = value; }
        public int SelectedRowId { get => selectedRowId; set => selectedRowId = value; }
        public string SelectedRowName { get => selectedRowName; set => selectedRowName = value; }
        public float SelectedRowPrice { get => selectedRowPrice; set => selectedRowPrice = value; }
        public int SelectedRowQuantity { get => selectedRowQuantity; set => selectedRowQuantity = value; }
        public string SelectedRowDescription { get => selectedRowDescription; set => selectedRowDescription = value; }
        public SqlConnection SqlConnection { get => sqlConnection; set => sqlConnection = value; }
        public SqlCommand SqlCommand { get => sqlCommand; set => sqlCommand = value; }


        public void populate(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            try
            {
                SqlQuery = "SELECT products.id As 'ID', products.name As 'Name', products.price As 'Price', products.description As 'Description',products.quantity As 'Quantity',categories.name As 'Category' " +
                    "FROM products " +
                    "JOIN categories ON categories.id = products.categoryId ORDER BY products.id ";
                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(SqlQuery, Connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                var dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridView.DataSource = dataSet.Tables[0];
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void changeNonCustomerLabels(DataGridView dataGridView, BunifuTextBox name, BunifuTextBox price, BunifuTextBox quantity, BunifuTextBox description, ComboBox category)
        {
            if (dataGridView.CurrentCell.RowIndex + 1 < dataGridView.RowCount)
            {
                string cat = dataGridView.SelectedRows[0].Cells["Category"].Value.ToString();
                SelectedRowId = Int32.Parse(dataGridView.SelectedRows[0].Cells["ID"].Value.ToString());
                SelectedRowName = dataGridView.SelectedRows[0].Cells["Name"].Value.ToString();
                SelectedRowPrice = float.Parse(dataGridView.SelectedRows[0].Cells["Price"].Value.ToString());
                SelectedRowQuantity = Int32.Parse(dataGridView.SelectedRows[0].Cells["Quantity"].Value.ToString());
                SelectedRowDescription = dataGridView.SelectedRows[0].Cells["Description"].Value.ToString();

                name.Text = SelectedRowName;
                price.Text = SelectedRowPrice.ToString();
                quantity.Text = SelectedRowQuantity.ToString();
                description.Text = SelectedRowDescription;
                category.Text = cat;
            }
        }

        public void changeCustomerLabels(DataGridView dataGridView, BunifuTextBox name, BunifuTextBox price, BunifuTextBox description, ComboBox category)
        {
            if (dataGridView.CurrentCell.RowIndex + 1 < dataGridView.RowCount)
            {
                string cat = dataGridView.SelectedRows[0].Cells["Category"].Value.ToString();
                SelectedRowId = Int32.Parse(dataGridView.SelectedRows[0].Cells["ID"].Value.ToString());
                SelectedRowName = dataGridView.SelectedRows[0].Cells["Name"].Value.ToString();
                SelectedRowPrice = float.Parse(dataGridView.SelectedRows[0].Cells["Price"].Value.ToString());
                SelectedRowQuantity = Int32.Parse(dataGridView.SelectedRows[0].Cells["Quantity"].Value.ToString());
                SelectedRowDescription = dataGridView.SelectedRows[0].Cells["Description"].Value.ToString();

                name.Text = SelectedRowName;
                price.Text = "Price: " + SelectedRowPrice.ToString();
                description.Text = SelectedRowDescription;
                if(cat != null)
                {
                    category.Text = cat;
                }
            }
        }
    }
}
