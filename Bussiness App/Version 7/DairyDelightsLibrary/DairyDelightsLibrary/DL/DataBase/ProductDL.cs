using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Interface;
using DairyDelightsLibrary.Utility;
using DairyDelightsLibrary.Validation;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DairyDelightsLibrary.DL.DataBase
{
    public class ProductDL : IProduct
    {
        static ProductDL Instance;
        private ProductDL()
        { }
        public static IProduct GetInstance(string Connection)
        {
            if (Instance == null)
            {
                Instance = new ProductDL();
            }
            return Instance;
        }
        public bool Addproduct(Product product)
        {
            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("Insert into Products(ProductName,Description,Price,Quantity,Discount) Values('{0}', '{1}', '{2}','{3}','{4}')", product.GetName(), product.GetDescription(), product.GetPrice(), product.GetQuantity(), product.GetDiscount());
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Result = true;
            }
            return Result;

        }
        public bool Removeproduct(string Name)
        {
            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("Delete from Products where ProductName = '{0}'", Name);

            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Result = true; 
            }
            return Result;

        }
        public bool CheckIfProductAlreadyExist(string Name)
        {
            string result = "";
            bool check = true;

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("select Price from Products where ProductName = '{0}'", Name);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                result = Convert.ToString(reader["Price"]);
            }
            if (result == "")
            {
                check = false;
            }
            return check;
        }
        public double GetQuantityOfProductAvailable(string Name)
        {
            string QuantityString = "";
            double Quantity;
            bool check = true;

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("select Quantity from Products where ProductName = '{0}'", Name);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                QuantityString = Convert.ToString(reader["Quantity"]);
            }
           
            if (!double.TryParse(QuantityString, out Quantity))
            {
                Quantity = 0.0;
            }
            return Quantity;
        }
        public double GetFinalPriceOfProductAvailable(string Name)
        {
            string PriceString = "", DiscountString = "";
            double FinalPrice, Price, Discount;

            string connectionString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = string.Format("select Price, Discount from Products where ProductName = '{0}'", Name);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                PriceString = Convert.ToString(reader["Price"]);
                DiscountString = Convert.ToString(reader["Discount"]);
            }

            Price = UserValidation.ConvertStringIntoDouble(PriceString);
            Discount = UserValidation.ConvertStringIntoDouble(DiscountString); // Corrected to use DiscountString

            FinalPrice = Price - (Discount * Price) / 100;

            return FinalPrice;
        }
        public bool ChangePriceByName(string name, string Price)
        {
            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("UPDATE Products SET Price = '{0}' WHERE ProductName = '{1}'", Price, name);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Result = true;
            }
            return Result;

        }
        public bool ChangeDescriptionByName(string name, string Description)
        {
            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("UPDATE Products SET Description = '{0}' WHERE ProductName = '{1}'", Description, name);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Result = true;
            }
            return Result;

        }
        public bool ChangeQuantityByName(string name, string Quantity)
        {
            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("UPDATE Products SET Quantity = '{0}' WHERE ProductName = '{1}'", Quantity, name);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Result = true;
            }
            return Result;

        }
        public bool ChangeDiscountByName(string name, string discount)
        {
            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("UPDATE Products SET Discount = '{0}' WHERE ProductName = '{1}'", discount, name);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Result = true;
            }
            return Result;

        }
        public bool AddReview(string name, string Review)
        {

            string UpdatedReview = "";

            if (GetReview(name) != "")
            {
                UpdatedReview = GetReview(name) + "%" + Review + "%";

            }
            else
            {
                UpdatedReview = Review + "%";

            }

            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("UPDATE Products SET Reviews = '{0}' WHERE ProductName = '{1}'", UpdatedReview, name);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Result = true;
            }
            return Result;
        }
        private string GetReview(string name)
        {
            string result = "";


            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("select Reviews from Products where ProductName = '{0}'", name);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                result = Convert.ToString(reader["Reviews"]);
            }
            return result;

        }
        public Product GetProductObjectfromName(string name)
        {
            Product product = null;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string Query = string.Format("select * from Products where ProductName = '{0}'", name);
            SqlCommand Command = new SqlCommand(Query, connection);
            SqlDataReader reader = Command.ExecuteReader();
            if (reader.Read())
            {
                //ProductName,Description,Price,Quantity,Discount
                string Productname = Convert.ToString(reader["ProductName"]);
                string description = Convert.ToString(reader["Description"]);
                string pricestring = Convert.ToString(reader["Price"]);
                string Quantitystring = Convert.ToString(reader["Quantity"]);
                string discountstring = Convert.ToString(reader["Discount"]);
                string reviewstring = Convert.ToString(reader["Reviews"]);
                List<string> list = ConvertStringIntoReviewsList(reviewstring);

                double price, Quantity, Discount;

                if (!double.TryParse(pricestring, out price))
                {
                    price = 0.0;
                }
                if (!double.TryParse(Quantitystring, out Quantity))
                {
                    Quantity = 0.0;
                }
                if (!double.TryParse(discountstring, out Discount))
                {
                    Discount = 0.0;
                }
                product = new Product(Productname, description, price, Quantity, Discount, list); //object is made
            }
            connection.Close();
            return product;
        }
        public List<Product> GetProductsList()
        {
            List<Product> Products = new List<Product>();
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string Query = string.Format("select * from Products");
            SqlCommand Command = new SqlCommand(Query, connection);
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {
                //ProductName,Description,Price,Quantity,Discount
                string Productname = Convert.ToString(reader["ProductName"]);
                string description = Convert.ToString(reader["Description"]);
                string pricestring = Convert.ToString(reader["Price"]);
                string Quantitystring = Convert.ToString(reader["Quantity"]);
                string discountstring = Convert.ToString(reader["Discount"]);
                string reviewstring = Convert.ToString(reader["Reviews"]);
                List<string> list = ConvertStringIntoReviewsList(reviewstring);

                double price, Quantity, Discount;

                if (!double.TryParse(pricestring, out price))
                {
                    price = 0.0;
                }
                if (!double.TryParse(Quantitystring, out Quantity))
                {
                    Quantity = 0.0;
                }
                if (!double.TryParse(discountstring, out Discount))
                {
                    Discount = 0.0;
                }
                Product Product1 = new Product(Productname, description, price, Quantity, Discount, list); //object is made
                Products.Add(Product1);
            }
            connection.Close();
            return Products;
        }
        public static List<string> ConvertStringIntoReviewsList(string String)
        {
            List<string> list = new List<string>();
            string[] split = String.Split('%');
            foreach (string s in split)
            {
                list.Add(s);
            }
            return list;
        }
    }
}
