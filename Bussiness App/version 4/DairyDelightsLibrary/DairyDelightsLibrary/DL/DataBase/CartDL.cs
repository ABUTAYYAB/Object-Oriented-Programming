using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Interface;
using DairyDelightsLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DairyDelightsLibrary.DL.DataBase
{
    public class CartDL :ICart
    {
        static CartDL Instance;
        private CartDL() 
        { }
        public static CartDL GetInstance(string Connection)
        {
            if(Instance == null)
            {
                CartDL instance = new CartDL();
            }
            return Instance;
        }
        public Cart GetCartFromUserName(string UserName) 
        {
            Cart UserCart = null; // Declare UserCart outside the if block and initialize it to null

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string Query = string.Format("select ProductsDetails, from Cart where UserName = '{0}'", UserName); // Fixed typo in SQL query
            SqlCommand Command = new SqlCommand(Query, connection);
            SqlDataReader reader = Command.ExecuteReader();
            if (reader.Read())
            {
                string AllProducts = Convert.ToString(reader["ProductsDetails"]);
                string Beforediscountstring = Convert.ToString(reader["CartPriceBeforeDiscount"]);
                string FinalPriceInstring = Convert.ToString(reader["CartFinalPrice"]);
                List<Product> products = GetProductsListFromString(AllProducts);
                double BeforeDiscount, FinalPrice;
                if (!double.TryParse(Beforediscountstring, out BeforeDiscount))
                {
                    BeforeDiscount = 0.0;
                }
                if (!double.TryParse(FinalPriceInstring, out FinalPrice))
                {
                    FinalPrice = 0.0;
                }
                UserCart = new Cart(UserName, products, BeforeDiscount, FinalPrice); // Assign UserCart inside the if block
            }
            connection.Close();
            return UserCart;




            //string connectiongString = Connection.GetConnectionString();
            //SqlConnection connection = new SqlConnection(connectiongString);
            //connection.Open();
            //string Query = string.Format("select ProductsDetails, from Cart where UserName = '{0}',", UserName);
            //SqlCommand Command = new SqlCommand(Query, connection);
            //SqlDataReader reader = Command.ExecuteReader();
            //if(reader.Read())
            //{
            //    string AllProducts= Convert.ToString(reader["ProductsDetails"]);
            //    string Beforediscountstring = Convert.ToString(reader["CartPriceBeforeDiscount"]);
            //    string FinalPriceInstring = Convert.ToString(reader["CartFinalPrice"]);
            //    List<Product> products = GetProductsListFromString(AllProducts);
            //    double BeforeDiscount, FinalPrice;
            //    if (!double.TryParse(Beforediscountstring, out BeforeDiscount))
            //    {
            //        BeforeDiscount = 0.0;
            //    }
            //    if (!double.TryParse(FinalPriceInstring, out FinalPrice))
            //    {
            //        FinalPrice = 0.0;
            //    }
            //     Cart UserCart = new Cart(UserName,products, BeforeDiscount, FinalPrice);
            //}
            //connection.Close();
            //return UserCart;
        }

        public bool AddCart(Cart cart)
        {
            bool Check = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("Insert into Cart(UserName,ProductsDetails,CartPriceBeforeDiscount,CartFinalPrice) Values('{0}', '{1}', '{2}','{3}','{4}')", cart.GetCustomerName(), cart.GetProductsInString(), cart.GetTotalPriceBeforeDiscount(), cart.GetTotalPriceAfterDiscount());
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Check = true;
            }
            return Check;
        }

        public bool RemoveCart(string Name)
        {
            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("Delete from Cart where UserName = '{0}'", Name);

            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Result = true;
            }
            return Result;

        }
        private List<Product> GetProductsListFromString(string Products)
        {
            List<Product> productList = new List<Product>();

            // Split the input string into individual product entries
            string[] productEntries = Products.Split('%');

            foreach (string entry in productEntries)
            {
                // Split each product entry into its components
                string[] components = entry.Split('|');
                if (components.Length == 4)
                {
                    string name = components[0];
                    double quantity, price, finalPrice;
                    // Parse quantity, price, and final price
                    if (double.TryParse(components[1], out quantity) &&
                        double.TryParse(components[2], out price) &&
                        double.TryParse(components[3], out finalPrice))
                    {
                        Product product = new Product(name, quantity, price, finalPrice);
                        productList.Add(product);
                    }
                }
            }
            return productList;
        }
        public bool AddProductInCart(string UserName,Product product)
        {

            string UpdatedProducts = "";

            if(GetProductsInStringFromDB(UserName) != "")
            {
                UpdatedProducts = UpdatedProducts + "%" + product.GetName() + "|" + product.GetQuantity() + "|" + product.GetPrice() + "|" + product.GetFinalPrice() + "%";
            }
            else
            {
                UpdatedProducts = product.GetName() + "|" + product.GetQuantity() + "|" + product.GetPrice() + "|" + product.GetFinalPrice() + "%";
            }
            double NewPrice, NewFinalPrice;

            NewPrice = CalculateTotalPrice(UpdatedProducts);
            NewFinalPrice = CalculateTotalFinalPrice(UpdatedProducts);

            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("UPDATE Cart SET ProductsDetails = '{0}', CartPriceBeforeDiscount = {1}, CartFinalPrice = {2} WHERE UserName = '{3}'", UpdatedProducts, NewPrice, NewFinalPrice, UserName);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Result = true;
            }
            return Result;


        }
        public string GetProductsInStringFromDB(string UserName)
        {
            string ProductsInString = "";


            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("select ProductsDetails from Cart where UserName = '{0}'", UserName);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                ProductsInString = Convert.ToString(reader["Reviews"]);
            }
            return ProductsInString;

        }
        private double CalculateTotalPrice(string Products)
        {
            double totalPrice = 0.0;

            // Split the input string into individual product entries
            string[] productEntries = Products.Split('%');

            foreach (string entry in productEntries)
            {
                // Split each product entry into its components
                string[] components = entry.Split('|');
                if (components.Length == 4)
                {
                    double price;
                    // Parse price
                    if (double.TryParse(components[2], out price))
                    {
                        totalPrice += price;
                    }
                }
            }
            return totalPrice;
        }
        private double CalculateTotalFinalPrice(string Products)
        {
            double totalFinalPrice = 0.0;

            // Split the input string into individual product entries
            string[] productEntries = Products.Split('%');

            foreach (string entry in productEntries)
            {
                // Split each product entry into its components
                string[] components = entry.Split('|');
                if (components.Length == 4)
                {
                    double finalPrice;
                    // Parse final price
                    if (double.TryParse(components[3], out finalPrice))
                    {
                        totalFinalPrice += finalPrice;
                    }
                }
            }
            return totalFinalPrice;
        }
    }
}
