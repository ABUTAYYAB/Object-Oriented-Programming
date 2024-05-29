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
        { }
        public static CartDL GetInstance(string Connection)
        {
            if (Instance == null)
            {
                CartDL instance = new CartDL();
            }
            return Instance;
        }
        public Cart GetCartFromUserName(string UserName)
        {
            Cart UserCart = new Cart();
            List<Product> Products = new List<Product>();

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string Query = string.Format("select * from UserCart where UserName = '{0}'", UserName);
            SqlCommand Command = new SqlCommand(Query, connection);
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {
                string ProductName = Convert.ToString(reader["ProductName"]);
                string PriceString = Convert.ToString(reader["ProductFinalPrice"]);
                string QuantityString = Convert.ToString(reader["Quantity"]);
                double Price, Quantity;
                if (!double.TryParse(PriceString, out Price))
                {
                    Price = 0.0;
                }
                if (!double.TryParse(QuantityString, out Quantity))
                {
                    Quantity = 0.0;
                }
                Product NewProduct = new Product(ProductName, Price, Quantity);
                Products.Add(NewProduct);
            }
            UserCart = new Cart(Products); // Assign UserCart inside the if block
            connection.Close();
            return UserCart;
        }

        public bool AddProductInCart(string UserName, Product product)
        {
            bool Check = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("Insert into UserCart(UserName,ProductName,ProductFinalPrice,ProductQuantity) Values('{0}', '{1}', '{2}','{3}','{4}')", UserName, product.GetName(), product.GetPrice(), product.GetQuantity());
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
                string QuantityString = Convert.ToString(reader["Quantity"]);

                if (!double.TryParse(QuantityString, out Quantity))
                {
                    Quantity = 0.0;
                }
            }
            return Quantity;
        }
        public bool UpdateQuantityInCart(string UserName,string ProductName,double Quantity)
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
        public bool RemoveCart(string UserName)
        {
            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("Delete from Cart where UserName = '{0}'", UserName);

            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Result = true;
            }
            return Result;

        }

    }
}
