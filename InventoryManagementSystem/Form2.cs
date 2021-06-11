using InventoryManagementSystem.Entities;
using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Form2 : Form
    {
        User user;
        public Form2(User user)
        {
            this.user = user;
            InitializeComponent();
            imgButton4.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Console.WriteLine("LOG: " + user.Name + "," + user.Password);
            imgButton1.Image = Properties.Resources.inventory_planning;
            imgButton2.Image = Properties.Resources.login_bg1;
            imgButton3.Image = Properties.Resources.login_bg2;
            // if comin entity is user, than show it to him
            if (user.Type.Equals("SUPERUSER"))
            {
                imgButton4.Visible = true;
                imgButton4.Image = Properties.Resources.login_bg;
            }
        }

        private void lbExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
         
        private void imgButton1_Click(object sender, EventArgs e)
        {
            Panel p = hostPanel;

            if (p != null)
            {
                while (p.Controls.Count > 0)
                {
                    p.Controls[0].Dispose();
                }

                Form3 myForm = new Form3
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

        private void imgButton2_Click(object sender, EventArgs e)
        {
            Panel p = hostPanel;

            if (p != null)
            {
                while (p.Controls.Count > 0)
                {
                    p.Controls[0].Dispose();
                }

                Form4 myForm = new Form4
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
    }
}
