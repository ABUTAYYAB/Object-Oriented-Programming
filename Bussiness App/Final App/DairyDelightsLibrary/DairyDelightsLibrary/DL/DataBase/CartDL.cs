using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Interface;
using DairyDelightsLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DairyDelightsLibrary.DL.DataBase
{
    public class CartDL : ICart
    {
        static CartDL Instance;
        private CartDL()
        {

        }
        public static CartDL GetInstance(string connection)
        {
            if (Instance == null)
            {
                Instance = new CartDL();
            }
            return Instance;
        }
        public List<Product> GetProductsListFromCart(String UserName)
        {
            List<Product> UserCart = new List<Product>();

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string Query = string.Format("select * from UserCart where UserName = '{0}'", UserName);
            SqlCommand Command = new SqlCommand(Query, connection);
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {
                //ProductName,Description,Price,Quantity,Discount
                string Productname = Convert.ToString(reader["ProductName"]);
                string pricestring = Convert.ToString(reader["ProductFinalPrice"]);
                string Quantitystring = Convert.ToString(reader["ProductQuantity"]);

                double price, Quantity;

                if (!double.TryParse(pricestring, out price))
                {
                    price = 0.0;
                }
                if (!double.TryParse(Quantitystring, out Quantity))
                {
                    Quantity = 0.0;
                }
                Product Product1 = new Product(Productname, price, Quantity); //object is made
                UserCart.Add(Product1);
            }
            connection.Close();
            return UserCart;
        }

        public bool AddProductInCart(string UserName, Product product)
        {
            bool Check = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("Insert into UserCart(UserName,ProductName,ProductFinalPrice,ProductQuantity) Values('{0}', '{1}', '{2}','{3}')", UserName, product.GetName(), product.GetPrice(), product.GetQuantity());
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Check = true;
            }
            return Check;
        }
        public bool RemoveProductFromCart(string UserName, string ProductName)
        {
            bool Check = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("delete from UserCart where UserName = '{0}' AND ProductName = '{1}' ", UserName, ProductName);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Check = true;
            }
            return Check;
        }

        public bool RemoveProductFromCartForAdmin(string ProductName)
        {
            bool Check = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("delete from UserCart where ProductName = '{0}' ", ProductName);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Check = true;
            }
            return Check;
        }
        public bool DeleteCart(string UserName)
        {
            bool Check = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("delete from UserCart where UserName = '{0}' ", UserName);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Check = true;
            }
            return Check;
        }

        public double GetProductQuantiytPresentInCart(string UserName, string ProductName)
        {
            double Quantity = 0;

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string Query = string.Format("select ProductQuantity from UserCart where UserName = '{0}' And ProductName = '{1}'", UserName, ProductName);
            SqlCommand Command = new SqlCommand(Query, connection);
            SqlDataReader reader = Command.ExecuteReader();

            if (reader.Read())
            {
                string QuantityString = Convert.ToString(reader["ProductQuantity"]);

                if (!double.TryParse(QuantityString, out Quantity))
                {
                    Quantity = 0.0;
                }
            }
            return Quantity;
        }
        public bool UpdateQuantityInCart(string UserName, string ProductName, double Quantity)
        {
            bool Check = false;

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("UPDATE UserCart SET ProductQuantity = '{0}' WHERE Username = '{1}' And ProductName = '{2}'", Quantity, UserName, ProductName);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Check = true;
            }
            return Check;
        }
        public bool IsProductAlreadyExistInCart(string UserName, string productName)
        {
            bool exists = false;
            string connectionString = Connection.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM UserCart WHERE UserName = @UserName AND ProductName = @ProductName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@ProductName", productName);

                int count = (int)command.ExecuteScalar();

                exists = (count > 0);

                connection.Close();
            }

            return exists;
        }

    }
}
