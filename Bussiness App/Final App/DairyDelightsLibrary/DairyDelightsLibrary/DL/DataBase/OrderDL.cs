using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Interface;
using DairyDelightsLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DairyDelightsLibrary.DL.DataBase
{
    public class OrderDL : IOrder
    {
        static OrderDL Instance;
        private OrderDL()
        {

        }
        public static OrderDL GetInstance(string Connection)
        {
            if (Instance == null)
            {
                Instance = new OrderDL();
            }
            return Instance;
        }

        public bool AddOrder(Order order)
        {

            bool Check = false;
            Customer customer = order.GetCustomer();
            Cart cart = order.GetCart();
            string connectionString = Connection.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Use parameterized queries to prevent SQL injection
                string query = "INSERT INTO [Order] (OrderID, ProductsDetails, CustomerName, CustomerPhoneNumber, CustomerAddress, Amount, DeliveryType, IsDelivered) " +
                               "VALUES (@OrderID, @ProductsDetails, @CustomerName, @CustomerPhoneNumber, @CustomerAddress, @Amount, @DeliveryType, @IsDelivered)";

                SqlCommand cmd = new SqlCommand(query, connection);

                // Add parameters to the query
                cmd.Parameters.AddWithValue("@OrderID", order.GetOrderID());
                cmd.Parameters.AddWithValue("@ProductsDetails", cart.GetProductsInString());
                cmd.Parameters.AddWithValue("@CustomerName", customer.GetUserName());
                cmd.Parameters.AddWithValue("@CustomerPhoneNumber", customer.GetPhoneNumber());
                cmd.Parameters.AddWithValue("@CustomerAddress", customer.GetAddress());
                cmd.Parameters.AddWithValue("@Amount", cart.GetTotalPriceOfCart());
                cmd.Parameters.AddWithValue("@DeliveryType", order.GetDeliveryType());
                cmd.Parameters.AddWithValue("@IsDelivered", order.GetIsDelivered());

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    Check = true;
                }
            }

            return Check;
        }

        public bool IsOrderIDAlreadyExisted(string orderID)
        {
            bool exists = false;

            string connectionString = Connection.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM [Order] WHERE OrderID = @OrderID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        exists = true;
                    }
                }
            }

            return exists;
        }
        public bool SetOrderDelivered(string orderID)
        {
            bool success = false;

            string connectionString = Connection.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE [Order] SET IsDelivered = 'Yes' WHERE OrderID = @OrderID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        success = true;
                    }
                }
            }

            return success;
        }

        public List<Order> GetOrderListbyUserName(string username)
        {
            List<Order> orderList = new List<Order>();

            string connectionString = Connection.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM [Order] WHERE CustomerName = @CustomerName";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerName", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string orderID = reader["OrderID"].ToString();
                            string productDetailsInString = reader["ProductsDetails"].ToString();
                            string UserName = reader["CustomerName"].ToString();
                            string PhoneNO = reader["CustomerPhoneNumber"].ToString();
                            string Address = reader["CustomerAddress"].ToString();
                            string Amount = reader["Amount"].ToString();
                            string DeliveryType = reader["DeliveryType"].ToString();
                            string IsDelivered = reader["IsDelivered"].ToString();

                            List<Product> products = GetProductsFromString(productDetailsInString);
                            Cart cart = new Cart(products);
                            Customer customer = new Customer(UserName, PhoneNO, Address);

                            Order order = new Order(orderID,cart,customer, DeliveryType, Amount);
                            order.SetIsDelivered(IsDelivered);
                            orderList.Add(order);
                        }
                    }
                }
            }

            return orderList;

        }
        public List<Order> GetUndeliveredOrders()
        {
            List<Order> undeliveredOrders = new List<Order>();

            string connectionString = Connection.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM [Order] WHERE IsDelivered = 'No'";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string orderID = reader["OrderID"].ToString();
                            string productDetailsInString = reader["ProductsDetails"].ToString();
                            string UserName = reader["CustomerName"].ToString();
                            string PhoneNO = reader["CustomerPhoneNumber"].ToString();
                            string Address = reader["CustomerAddress"].ToString();
                            string Amount = reader["Amount"].ToString();
                            string DeliveryType = reader["DeliveryType"].ToString();
                            string IsDelivered = reader["IsDelivered"].ToString();

                            List<Product> products = GetProductsFromString(productDetailsInString);
                            Cart cart = new Cart(products);
                            Customer customer = new Customer(UserName, PhoneNO, Address);

                            Order order = new Order(orderID, cart, customer, DeliveryType, Amount);
                            order.SetIsDelivered(IsDelivered);
                            undeliveredOrders.Add(order);
                        }
                    }
                }
            }

            return undeliveredOrders;
        }
        public List<Order> GetDeliveredOrders()
        {
            List<Order> deliveredOrders = new List<Order>();

            string connectionString = Connection.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM [Order] WHERE IsDelivered = 'Yes'";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string orderID = reader["OrderID"].ToString();
                            string productDetailsInString = reader["ProductsDetails"].ToString();
                            string UserName = reader["CustomerName"].ToString();
                            string PhoneNO = reader["CustomerPhoneNumber"].ToString();
                            string Address = reader["CustomerAddress"].ToString();
                            string Amount = reader["Amount"].ToString();
                            string DeliveryType = reader["DeliveryType"].ToString();
                            string IsDelivered = reader["IsDelivered"].ToString();

                            List<Product> products = GetProductsFromString(productDetailsInString);
                            Cart cart = new Cart(products);
                            Customer customer = new Customer(UserName, PhoneNO, Address);

                            Order order = new Order(orderID, cart, customer, DeliveryType, Amount);
                            order.SetIsDelivered(IsDelivered);
                            deliveredOrders.Add(order);
                        }
                    }
                }
            }

            return deliveredOrders;
        }
        public double GetSales()
        {

            double totalSales = 0;
            List<Order> deliveredOrders = GetDeliveredOrders();
            foreach (Order order in deliveredOrders)
            {
                totalSales += order.GetCart().GetTotalPriceOfCart();
            }
            return totalSales;
        }
        public List<Product> GetProductDetailsByOrderId(string orderId)
        {
            string productDetails = "";
            string connectionString = Connection.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ProductsDetails FROM [Order] WHERE OrderID = @OrderId";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@OrderId", orderId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        productDetails = reader["ProductsDetails"].ToString();
                    }
                }
            }
                List<Product> products = GetProductsFromString(productDetails);

            return products;
        }
        public List<Order> GetAllOrders()
        {
            List<Order> allOrders = new List<Order>();

            string connectionString = Connection.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM [Order]";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string orderID = reader["OrderID"].ToString();
                            string productDetailsInString = reader["ProductsDetails"].ToString();
                            string UserName = reader["CustomerName"].ToString();
                            string PhoneNO = reader["CustomerPhoneNumber"].ToString();
                            string Address = reader["CustomerAddress"].ToString();
                            string Amount = reader["Amount"].ToString();
                            string DeliveryType = reader["DeliveryType"].ToString();
                            string IsDelivered = reader["IsDelivered"].ToString();

                            List<Product> products = GetProductsFromString(productDetailsInString);
                            Cart cart = new Cart(products);
                            Customer customer = new Customer(UserName, PhoneNO, Address);

                            Order order = new Order(orderID, cart, customer, DeliveryType, Amount);
                            order.SetIsDelivered(IsDelivered);
                            allOrders.Add(order);
                        }
                    }
                }
            }

            return allOrders;
        }


        private List<Product> GetProductsFromString(string productsString)
        {
            List<Product> productList = new List<Product>();
            string[] productStrings = productsString.Split('%');

            foreach (string productString in productStrings)
            {
                string[] attributes = productString.Split('|');

                if (attributes.Length == 3) 
                {
                    string name = attributes[0];
                    double Price = double.Parse(attributes[1]);
                    double quantity = double.Parse(attributes[2]);
                    productList.Add(new Product(name, Price, quantity));
                }
            }

            return productList;
        }

    }
}
