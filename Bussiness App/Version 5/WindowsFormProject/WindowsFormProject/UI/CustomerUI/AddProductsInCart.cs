using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Interface;
using DairyDelightsLibrary.Validation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormProject.UI.CustomerUI
{
    public partial class AddProductsInCart : UserControl
    {
        ICart cart = ObjectHandler.GetCartInstance();
        IUser user = ObjectHandler.GetUserInstance();
        IProduct product = ObjectHandler.GetProductInstance();

        public AddProductsInCart()
        {
            InitializeComponent();
            LoadGridBox();
        }
        private void LoadGridBox()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price", typeof(string));

            dataGridView1.DataSource = dt;
            List<Product> List = product.GetProductsList();
            foreach (Product product1 in List)
            {
                dt.Rows.Add(product1.GetName(), product1.GetPrice());
            }
            dataGridView1.DataSource = dt;
        }

        private void AddProductsInCart_Load(object sender, EventArgs e)
        {

        }
        private void ClearData()
        {
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string UserName = user.GetActiveUser();
            string name = guna2TextBox1.Text;
            string QuantityString = guna2TextBox2.Text;

            // Add null check for product object
            Product Product1 = product.GetProductObjectfromName(Name);
            if (Product1 == null)
            {
                MessageBox.Show("Product not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(QuantityString))
                {
                    if (product.CheckIfProductAlreadyExist(name))
                    {
                        if (UserValidation.IsConvertibleToDouble(QuantityString))
                        {
                            double Quantity = UserValidation.ConvertStringIntoDouble(QuantityString);

                            // Add null check for cart object
                            if (Quantity + cart.GetProductQuantiytPresentInCart(UserName, name) < product.GetQuantityOfProductAvailable(name))//Product1.GetQuantity()   cart != null && 
                            {
                                Product CartProduct = new Product(name, Product1.GetFinalPrice(), Quantity);
                                bool check = cart.AddProductInCart(UserName, CartProduct);
                                if (check)
                                {
                                    MessageBox.Show("Done");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Sorry, this much quantity is not available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Quantity must be a valid number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter a valid product name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter all data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*private void guna2Button1_Click(object sender, EventArgs e)
        {
            string UserName = user.GetActiveUser();
            string name = guna2TextBox1.Text;
            string QuantityString = guna2TextBox2.Text;
            Product Product1 = product.GetProductObjectfromName(Name);
            try
            {
                if (name != "" && QuantityString != "")
                {
                    if (product.CheckIfProductAlreadyExist(name))
                    {
                        if (UserValidation.IsConvertibleToDouble(QuantityString))
                        {
                            double Quantity = UserValidation.ConvertStringIntoDouble(QuantityString);
                            double buyingQuantity, QuantityAvailable;
                            buyingQuantity = Quantity + cart.GetProductQuantiytPresentInCart(UserName, name);
                            QuantityAvailable = Product1.GetQuantity();
                            if (buyingQuantity <= QuantityAvailable)
                            {
                                Product CartProduct = new Product(name, Product1.GetFinalPrice(), Quantity);
                                bool check = cart.AddProductInCart(UserName, CartProduct);
                                if (check)
                                {
                                    MessageBox.Show("Done");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Sorry This Much quantity is not Available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Quantity Must be valid Integer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Valid Product Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter All Data ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }*/
    }
}
