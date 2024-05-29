using DairyDelightsLibrary.BL;
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
    public class DeliveryBoyDL : iDeliveryBoy
    {
        static DeliveryBoyDL Instance;
        private DeliveryBoyDL()
        {
        }
        public static DeliveryBoyDL GetInstance(string Connection)
        {
            if (Instance == null)
            {
                Instance = new DeliveryBoyDL();
            }
            return Instance;
        }

        public bool ChangePasswordByUserName(string Username, string Password)
        {
            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("UPDATE Credentials SET Password = '{0}' WHERE Username = '{1}'", Password, Username);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Result = true;
            }
            return Result;
        }

        public List<DeliveryBoy> GetDeliveryBoyList()
        {
            List<DeliveryBoy> deliveryBoys = new List<DeliveryBoy>();

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string Query = string.Format("select * from DeliveryBoy");
            SqlCommand Command = new SqlCommand(Query, connection);
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {
                string username = Convert.ToString(reader["Username"]);
                string BikeNo = Convert.ToString(reader["BikeNo"]);
                string PhoneNo = Convert.ToString(reader["PhoneNo"]);
                string salaryString = Convert.ToString(reader["Salary"]); // Retrieve salary as string

                double salary; // Declare salary variable

                // Try parsing the salary string into a double
                if (!double.TryParse(salaryString, out salary))
                {
                    salary = 0.0;
                }
                User user = new User(username, FindPasswordByUserName(username), "DeliveryBoy");
                DeliveryBoy deliveryBoy = new DeliveryBoy(user, BikeNo, PhoneNo, salary);

                deliveryBoys.Add(deliveryBoy);
            }
            connection.Close();
            return deliveryBoys;
        }
        public string FindPasswordByUserName(string UserName)
        {
            string result = "";

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("select Password from Credentials where Username = '{0}'", UserName);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                result = Convert.ToString(reader["Password"]);
            }
            return result;
        }
        public string GetSalaryByUserName(string UserName)
        {
            string result = "";

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("select Salary from DeliveryBoy where Username = '{0}'", UserName);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                result = Convert.ToString(reader["Salary"]);
            }
            return result;
        }
        public string GetBikeNumberByUserName(string UserName)
        {
            string result = "";

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("select BikeNo from DeliveryBoy where Username = '{0}'", UserName);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                result = Convert.ToString(reader["BikeNo"]);
            }
            return result;
        }
        public string GetPhoneNumberByUserName(string UserName)
        {
            string result = "";

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("select PhoneNo from DeliveryBoy where Username = '{0}'", UserName);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                result = Convert.ToString(reader["PhoneNo"]);
            }
            return result;
        }
        public bool ChangeSalaryByUserName(string Username, string Salary)
        {
            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("UPDATE DeliveryBoy SET Salary = '{0}' WHERE Username = '{1}'", Salary, Username);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Result = true;
            }
            return Result;

        }
        public bool ChangeBikeNumByUserName(string Username, string BikeNo)
        {
            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("UPDATE DeliveryBoy SET BikeNo = '{0}' WHERE Username = '{1}'", BikeNo, Username);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Result = true;
            }
            return Result;

        }
        public bool ChangePhoneNumByUserName(string Username, string PhoneNo)
        {
            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("UPDATE DeliveryBoy SET PhoneNo = '{0}' WHERE Username = '{1}'", PhoneNo, Username);
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
