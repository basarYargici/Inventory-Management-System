using InventoryManagementSystem.Entities;
using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    enum UserTypes
    {
        SUPERUSER,
        EMPLOYEE,
        CUSTOMER
    }

    public partial class MainForm : Form
    {
        User user;
        public MainForm(User user)
        {
            this.user = user;
            InitializeComponent();
            btnProducts.Visible = false;
            btnOrders.Visible = false;
            btnEmployees.Visible = false;
            btnCategories.Visible = false;
            btnCustomers.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnProducts.Image = Properties.Resources.products;
            btnOrders.Image = Properties.Resources.orders;
            btnEmployees.Image = Properties.Resources.employee;
            btnCategories.Image = Properties.Resources.categories;
            btnCustomers.Image = Properties.Resources.customers;

            // if user is SUPERUSER, show all
            if (user.Type.Equals(UserTypes.SUPERUSER.ToString()))
            {
                btnProducts.Visible = true;
                btnOrders.Visible = true;
                btnCategories.Visible = true;
                btnCustomers.Visible = true;
                btnEmployees.Visible = true;
            } // if user is EMPLOYEE, show all, but btnEmployees
            else if (user.Type.Equals(UserTypes.EMPLOYEE.ToString()))
            {
                btnProducts.Visible = true;
                btnOrders.Visible = true;
                btnCategories.Visible = true;
                btnCustomers.Visible = true;
            } // if user is CUSTOMER, show only btnProducts and btnOrders
            else if (user.Type.Equals(UserTypes.CUSTOMER.ToString()))
            {
                btnProducts.Visible = true;
                btnOrders.Visible = true;
            }
            else
            {
                throw new Exception("Unrecognized user type!");
            }
        }

        private void lbExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm()
            {
                Location = Location,
                Size = Size,
                StartPosition = StartPosition
            }.ShowDialog();
            this.Close();

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            if (!user.Type.Equals(UserTypes.CUSTOMER.ToString()))
            {
                openForm(new NonCustomerProductsForm(), hostPanel);
            }
            else
            {
                openForm(new CustomerProductsForm(user), hostPanel);
            }
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            openForm(new EmployeesForm(), hostPanel);

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            openForm(new CustomersForm(user), hostPanel);
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            openForm(new CategoriesForm(), hostPanel);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            openForm(new OrdersForm(user), hostPanel);
        }

        private void openForm(Form form, Panel hostPanel)
        {

            if (hostPanel != null)
            {
                while (hostPanel.Controls.Count > 0)
                {
                    hostPanel.Controls[0].Dispose();
                }

                form.FormBorderStyle = FormBorderStyle.None;
                form.TopLevel = false;
                form.AutoScroll = true;
                form.Dock = DockStyle.Fill;

                hostPanel.Controls.Add(form);
                //listView1.SmallImageList = ımageList1;

                form.Show();
                // this.Close();
            }
        }


    }
}
