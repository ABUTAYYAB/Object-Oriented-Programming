using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.DL.DataBase;
using DairyDelightsLibrary.Interface;
using DairyDelightsLibrary.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormProject.UI
{
    public partial class UpdateProduct : UserControl
    {
        IProduct product = ObjectHandler.GetProductInstance();
        public UpdateProduct()
        {
            InitializeComponent();
            LoadGridBox();
        }
        private void LoadGridBox()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price", typeof(string));
            dt.Columns.Add("Quantity", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Discount", typeof(string));
            dt.Columns.Add("final Price", typeof(string));

            dataGridView1.DataSource = dt;
            List<Product> List = product.GetProductsList();
            foreach (Product product1 in List)
            {
                dt.Rows.Add(product1.GetName(), product1.GetPrice(), product1.GetQuantity(),product1.GetDescription(), product1.GetDiscount(),product1.GetFinalPrice());
            }
            dataGridView1.DataSource = dt;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                string Name = guna2TextBox1.Text;
                string price = guna2TextBox2.Text;
                string quantity = guna2TextBox3.Text;
                string details = guna2TextBox4.Text;
                string discount = guna2TextBox5.Text;
                if (Name != "")
                {
                    if (UserValidation.IsStringValid(price) && UserValidation.IsStringValid(quantity) && UserValidation.IsStringValid(details) && UserValidation.IsStringValid(discount))
                    {
                        if (UserValidation.IsConvertibleToDouble(price)&& UserValidation.IsConvertibleToDouble(quantity) && UserValidation.IsConvertibleToDouble(discount))
                        {
                            bool check = product.CheckIfProductAlreadyExist(Name);
                            if (check)
                            {
                                if (price != "")
                                {
                                    bool Ispricechanged = product.ChangePriceByName(Name, price);
                                }
                                if (quantity != "")
                                {
                                    bool IsquantityChanged = product.ChangeQuantityByName(Name, quantity);
                                }
                                if (details != "")
                                {
                                    bool IsdetailsChanged = product.ChangeDescriptionByName(Name, details);
                                }
                                if (discount != "")
                                {
                                    bool ISDiscountChanged = product.ChangeDiscountByName(Name, discount);
                                }
                                ClearData();
                                LoadGridBox();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Enter valid integer in Price,Quantity,Discount ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Data Cannot Contain Letter '%' OR ','.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Enter Name Of Product.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ClearData()
        {
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";
            guna2TextBox4.Text = "";
            guna2TextBox5.Text = "";


        }
    }
}
