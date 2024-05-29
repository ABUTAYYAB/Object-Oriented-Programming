using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormProject.UI
{
    public partial class CheckReviewofProducts : UserControl
    {
        IProduct product = Program.GetProductInstance();
        public CheckReviewofProducts()
        {
            InitializeComponent();
            LoadGridBox();
        }
        private void LoadGridBox()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Reviews", typeof(string));

            List<Product> products = new List<Product>();

            foreach (Product product in products)
            {
                List<string> list = product.GetReviews();
                foreach (string complaint in list)
                {
                    dt.Rows.Add(product.GetName(), complaint);
                }
            }

            dataGridView1.DataSource = dt;
        }
        private void ViewComplainsOfScpecificProduct(string name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Reviews", typeof(string));

            List<Product> products = new List<Product>();

            foreach (Product product in products)
            {
                List<string> list = product.GetReviews();
                for (int i = 0; i < list.Count; i++)
                {
                    if (product.GetName() == name)
                    {
                        dt.Rows.Add(product.GetName(), list[i]);

                    }
                }
            }

            dataGridView1.DataSource = dt;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = guna2TextBox1.Text;
                if (name == "")
                {
                    LoadGridBox();
                }
                else if (product.CheckIfProductAlreadyExist(name))
                {
                    ViewComplainsOfScpecificProduct(name);
                }
                else
                {
                    MessageBox.Show("Incorrect Username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearData();
            }

        }
        private void ClearData()
        {
            guna2TextBox1.Text = "";
        }
    }
}
