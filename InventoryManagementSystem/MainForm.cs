using InventoryManagementSystem.Entities;
using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
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

        private void Form2_Load(object sender, EventArgs e)
        {
            btnProducts.Image = Properties.Resources.products;
            btnOrders.Image = Properties.Resources.orders;
            btnEmployees.Image = Properties.Resources.employee;
            btnCategories.Image = Properties.Resources.categories;
            btnCustomers.Image = Properties.Resources.customers;

            // if user is SUPERUSER, show all
            if (user.Type.Equals("SUPERUSER"))
            {
                btnProducts.Visible = true;
                btnOrders.Visible = true;
                btnCategories.Visible = true;
                btnCustomers.Visible = true;
                btnEmployees.Visible = true;
            } // if user is EMPLOYEE, show all, but btnEmployees
            else if (user.Type.Equals("EMPLOYEE"))
            {
                btnProducts.Visible = true;
                btnOrders.Visible = true;
                btnCategories.Visible = true;
                btnCustomers.Visible = true;
            } // if user is CUSTOMER, show only btnProducts and btnOrders
            else if (user.Type.Equals("CUSTOMER"))
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
            Panel p = hostPanel;

            if (p != null)
            {
                while (p.Controls.Count > 0)
                {
                    p.Controls[0].Dispose();
                }

                ProductsForm myForm = new ProductsForm
                {
                    FormBorderStyle = FormBorderStyle.None,
                    TopLevel = false,
                    AutoScroll = true,
                    Dock = DockStyle.Fill
                };

                p.Controls.Add(myForm);
                //listView1.SmallImageList = ımageList1;


                myForm.Show();
                // this.Close();
            }
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Panel p = hostPanel;

            if (p != null)
            {
                while (p.Controls.Count > 0)
                {
                    p.Controls[0].Dispose();
                }

                EmployeesForm myForm = new EmployeesForm
                {
                    FormBorderStyle = FormBorderStyle.None,
                    TopLevel = false,
                    AutoScroll = true,
                    Dock = DockStyle.Fill
                };

                p.Controls.Add(myForm);
                //listView1.SmallImageList = ımageList1;


                myForm.Show();
                // this.Close();
            }

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Panel p = hostPanel;

            if (p != null)
            {
                while (p.Controls.Count > 0)
                {
                    p.Controls[0].Dispose();
                }

                CustomersForm myForm = new CustomersForm
                {
                    FormBorderStyle = FormBorderStyle.None,
                    TopLevel = false,
                    AutoScroll = true,
                    Dock = DockStyle.Fill
                };

                p.Controls.Add(myForm);
                //listView1.SmallImageList = ımageList1;


                myForm.Show();
                // this.Close();
            }
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Panel p = hostPanel;

            if (p != null)
            {
                while (p.Controls.Count > 0)
                {
                    p.Controls[0].Dispose();
                }

                CategoriesForm myForm = new CategoriesForm
                {
                    FormBorderStyle = FormBorderStyle.None,
                    TopLevel = false,
                    AutoScroll = true,
                    Dock = DockStyle.Fill
                };

                p.Controls.Add(myForm);
                //listView1.SmallImageList = ımageList1;


                myForm.Show();
                // this.Close();
            }
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Panel p = hostPanel;

            if (p != null)
            {
                while (p.Controls.Count > 0)
                {
                    p.Controls[0].Dispose();
                }

                OrdersForm myForm = new OrdersForm
                {
                    FormBorderStyle = FormBorderStyle.None,
                    TopLevel = false,
                    AutoScroll = true,
                    Dock = DockStyle.Fill
                };

                p.Controls.Add(myForm);
                //listView1.SmallImageList = ımageList1;


                myForm.Show();
                // this.Close();
            }
        }


    }
}
