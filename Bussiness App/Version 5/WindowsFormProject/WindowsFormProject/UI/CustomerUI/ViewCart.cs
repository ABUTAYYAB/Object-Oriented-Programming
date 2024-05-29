using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormProject.UI.CustomerUI
{
    public partial class ViewCart : UserControl
    {
        ICart cart = ObjectHandler.GetCartInstance();
        IUser user = ObjectHandler.GetUserInstance();
        public ViewCart()
        {
            InitializeComponent();
            LoadGridBox();
        }
        private void LoadGridBox()
        {
            try
            {
                string username = user.GetActiveUser();

                // Check if cart object is initialized
                if (cart != null)
                {
                    Cart UserCart = cart.GetCartFromUserName(username);

                    if (UserCart != null)
                    {
                        double CartPrice = UserCart.GetTotalPrice();

                        DataTable dt = new DataTable();
                        dt.Columns.Add("Name", typeof(string));
                        dt.Columns.Add("Price", typeof(string));
                        dt.Columns.Add("Quantity", typeof(string));

                        List<Product> Products = UserCart.GetProducts();

                        dataGridView1.DataSource = dt;

                        foreach (Product product in Products)
                        {
                            string name = product.GetName() ?? "N/A"; // Handle null name
                            string price = product.GetPrice() != null ? product.GetPrice().ToString() : "N/A"; // Handle null price
                            string quantity = product.GetQuantity() != null ? product.GetQuantity().ToString() : "N/A"; // Handle null quantity

                            dt.Rows.Add(name, price, quantity);
                        }

                        dataGridView1.DataSource = dt;

                        guna2TextBox1.Text = CartPrice.ToString();
                        guna2TextBox1.ReadOnly = true;
                    }
                    else
                    {
                        // If the user's cart is empty, display a message to the user
                        MessageBox.Show("Your Cart Is Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Cart object is not initialized", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*private void LoadGridBox()
        {
            try
            {
                string username = user.GetActiveUser();
                Cart UserCart = cart.GetCartFromUserName(username);
                if (UserCart != null)
                {
                    double CartPrice = UserCart.GetTotalPrice();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Name", typeof(string));
                    dt.Columns.Add("Price", typeof(string));
                    dt.Columns.Add("Quantity", typeof(string));

                    List<Product> Products = UserCart.GetProducts();

                    dataGridView1.DataSource = dt;

                    foreach (Product product in Products)
                    {
                        dt.Rows.Add(product.GetName(), product.GetPrice(), product.GetQuantity());
                    }

                    dataGridView1.DataSource = dt;

                    guna2TextBox1.Text = CartPrice.ToString();
                    guna2TextBox1.ReadOnly = true;
                }
                else
                {
                    // If the user's cart is empty, display a message to the user
                    MessageBox.Show("Your Cart Is Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        /*private void LoadGridBox()
        {
            try
            {
                string username = user.GetActiveUser();
                Cart UserCart = cart.GetCartFromUserName(username);
                if (UserCart != null)
                {
                    double CartPrice = UserCart.GetTotalPrice();


                    DataTable dt = new DataTable();
                    dt.Columns.Add("Name", typeof(string));
                    dt.Columns.Add("Price", typeof(string));
                    dt.Columns.Add("Quantity", typeof(string));


                    List<Product> Products = UserCart.GetProducts();

                    dataGridView1.DataSource = dt;

                    foreach (Product product in Products)
                    {
                        dt.Rows.Add(product.GetName(), product.GetPrice(), product.GetQuantity());
                    }
                    dataGridView1.DataSource = dt;

                    guna2TextBox1.Text = CartPrice.ToString();
                    guna2TextBox1.ReadOnly = true;

                }
                else
                {
                    DisplayMessage("Your Cart Is Empty");
                }

            }
            catch
            {
                MessageBox.Show("Your Cart Is Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



        }*/
        private void DisplayMessage(string message)
        {
            // Add a new row to the DataGridView
            int rowIndex = dataGridView1.Rows.Add();

            // Set the message in the appropriate cell (e.g., first cell)
            dataGridView1.Rows[rowIndex].Cells[0].Value = message;
        }
    }
}
