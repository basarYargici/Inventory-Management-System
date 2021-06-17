using InventoryManagementSystem.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class OrdersForm : Form
    {
        private SqlConnection sqlConnection;
        private readonly string connection = "Data Source=192.168.0.31;Initial Catalog=finalDB;Persist Security Info=True;User ID=SA;Password=password1";
        User user;

        public OrdersForm(User user)
        {
            this.user = user;
            InitializeComponent();
            sqlConnection = new SqlConnection(connection);
        }
        public void populate()
        {
            try
            {
                var sqlQuery = "SELECT products.id As 'ID', products.name As 'Name', products.price As 'Price', products.description As 'Description',products.quantity As 'Quantity',categories.name As 'Category' FROM products JOIN categories ON categories.id = products.categoryId ORDER BY products.id ";
                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                var dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dgvOrders.DataSource = dataSet.Tables[0];
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void OrdersForm_Load(object sender, System.EventArgs e)
        {
            if (user.Type.Equals(UserTypes.CUSTOMER.ToString()))
            {
                populate();
            }
            else
            {
                populate();
            }
        }
    }
}
