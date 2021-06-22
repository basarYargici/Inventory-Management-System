using InventoryManagementSystem.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class OrdersForm : Form
    {
        private readonly string connection = "Data Source=192.168.0.31;Initial Catalog=finalDB;Persist Security Info=True;User ID=SA;Password=password1";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;

        User user;
        private string tempQuery;
        private float bill;
        private int orderCount;

        public OrdersForm(User user)
        {
            this.user = user;
            InitializeComponent();
            dgvOrders.ReadOnly = true;
            sqlConnection = new SqlConnection(connection);
        }
        public void populate(string sqlQuery)
        {
            try
            {
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

        private float getBill(User user)
        {
            try
            {
                tempQuery = "SELECT customers.mail AS 'Mail', customers.bill AS 'Bill' FROM customers " +
                    "JOIN users ON customers.mail = users.mail WHERE customers.mail = '" + user.Mail + "';";

                sqlConnection.Open();

                sqlCommand = new SqlCommand(tempQuery, sqlConnection); // execute sql command with connection and parameters

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    bill = float.Parse(reader[1].ToString());
                }
                // Console.WriteLine(bill);

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return bill;
        }

        private int getTotalOrderCount()
        {
            try
            {
                tempQuery = "SELECT COUNT(*) FROM customers_products;";


                sqlConnection.Open();

                sqlCommand = new SqlCommand(tempQuery, sqlConnection); // execute sql command with connection and parameters

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    orderCount = Int32.Parse(reader[0].ToString());
                }
                // Console.WriteLine(bill);

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return orderCount;
        }

        private void OrdersForm_Load(object sender, System.EventArgs e)
        {
            getBill(user);
            getTotalOrderCount();
            if (user.Type.Equals(UserTypes.CUSTOMER.ToString()))
            {
                lblTotal.Text = "TOTAL FEE: " + bill.ToString();
                tempQuery = "SELECT customers.mail AS 'Mail', products.name As 'Name', customers_products.product_count AS 'Piece', customers_products.product_count * products.price As 'Price', " +
                    "products.description As 'Description', customers_products.date As 'Date', categories.name As 'Category'from customers_products " +
                    "JOIN customers ON customers_products.customer_id = customers.mail " +
                    "JOIN products ON customers_products.product_id = products.id " +
                    "JOIN categories ON categories.id = products.categoryId WHERE customers.mail = '" + user.Mail + "' ORDER BY Date desc";
                populate(tempQuery);
            }
            else
            {
                lblTotal.Text = "TOTAL ORDER COUNT: " + orderCount.ToString();
                tempQuery = "SELECT customers.mail AS 'Mail', products.name As 'Name', customers_products.product_count AS 'Piece', customers_products.product_count * products.price As 'Price', " +
                    "products.description As 'Description', customers_products.date As 'Date', categories.name As 'Category'from customers_products " +
                    "JOIN customers ON customers_products.customer_id = customers.mail " +
                    "JOIN products ON customers_products.product_id = products.id " +
                    "JOIN categories ON categories.id = products.categoryId " +
                    "ORDER BY Date desc";
                populate(tempQuery);
            }
        }
    }
}
