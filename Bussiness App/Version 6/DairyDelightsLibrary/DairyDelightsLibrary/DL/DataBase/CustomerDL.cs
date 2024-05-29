using DairyDelightsLibrary.Interface;
using DairyDelightsLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.DL.DataBase
{
    public class CustomerDL : ICustomer
    {

        static CustomerDL Instance;
        private CustomerDL()
        {
        }
        public static CustomerDL GetInstance(string Connection)
        {
            if (Instance == null)
            {
                Instance = new CustomerDL();
            }
            return Instance;
        }
        public bool CheckIfDetailsOfUserAreEntered(string UserName)
        {
            string phoneno = "";
            string address = "";

            bool check = false;

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("select PhoneNo,Address from Customer where Username = '{0}'", UserName);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                phoneno = Convert.ToString(reader["PhoneNo"]);
                address = Convert.ToString(reader["Address"]);

            }
            if (phoneno != "" && address !="")
            {
                check = true;
            }
            return check;
        }
        public bool ChangePhonenNumberByUserName(string Username, string PhoneNo)
        {
            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("UPDATE Customer SET PhoneNo = '{0}' WHERE Username = '{1}'", PhoneNo, Username);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Result = true;
            }
            return Result;

        }
        public string GetPhonenNumberByUserName(string UserName)
        {
            string phoneno = "";

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("select PhoneNo from Customer where Username = '{0}'", UserName);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                phoneno = Convert.ToString(reader["PhoneNo"]);

            }
            
            return phoneno;

        }
        public bool ChangeAddressByUserName(string Username, string Address)
        {
            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("UPDATE Customer SET Address = '{0}' WHERE Username = '{1}'", Address, Username);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            //string query = "UPDATE Customer SET Address = @Address WHERE Username = @Username";
            //SqlCommand cmd = new SqlCommand(query, connection);
            //cmd.Parameters.AddWithValue("@Address", Address);
            //cmd.Parameters.AddWithValue("@Username", Username);
            //int rows = cmd.ExecuteNonQuery();

            connection.Close();
            if (rows > 0)
            {
                Result = true;
            }
            return Result;
        }
        public string GetAddressByUserName(string UserName)
        {
            string Address = "";

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("select Address from Customer where Username = '{0}'", UserName);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Address = Convert.ToString(reader["Address"]);

            }
            return Address;
        }
    }
}
