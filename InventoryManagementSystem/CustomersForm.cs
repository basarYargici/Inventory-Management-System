using InventoryManagementSystem.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class CustomersForm : Form
    {
        private string connection = "Data Source=192.168.0.31;Initial Catalog=finalDB;Persist Security Info=True;User ID=SA;Password=password1";
        private string sqlQuery;
        SqlConnection sqlConnection;
        User user;

        public CustomersForm(User user)
        {
            this.user = user;
            InitializeComponent();
            sqlConnection = new SqlConnection(connection);
            dgvCustomers.ReadOnly = true;
        }

        public void populate()
        {
            try
            {
                sqlQuery = "SELECT customers.mail As 'Mail',customers.bill As 'Bill',count(customers_products.customer_id) As 'Order Count' FROM customers " +
                    "LEFT JOIN customers_products ON customers_products.customer_id = customers.mail " +
                    "GROUP BY customers.mail,customers.bill ";
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
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void CustomersForm_Load(object sender, System.EventArgs e)
        {
            populate();
        }
    }
}
