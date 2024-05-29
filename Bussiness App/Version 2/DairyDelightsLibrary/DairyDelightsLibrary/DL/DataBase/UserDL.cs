using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.DL.DataBase
{
    public class UserDL
    {
        public static bool SignUP(User user)
        {
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("Insert into Credentials(Username,Password,Role) Values('{0}', '{1}', '{2}')", user.GetUserName(), user.GetPassword(), user.GetRole());
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            
            if (user.GetRole() == "Customer")
            {
                connection.Open();
                string QueryCustomer = string.Format("Insert into Customer(Username) Values('{0}')", user.GetUserName());
                SqlCommand cmdCustomer = new SqlCommand(QueryCustomer, connection); // Corrected variable name
                int Rows = cmdCustomer.ExecuteNonQuery(); // Corrected variable name
                connection.Close();
            }
            else if (user.GetRole() == "DeliveryBoy")
            {
                connection.Open();
                string QueryDeliveryBoy = string.Format("Insert into DeliveryBoi(Username) Values('{0}')", user.GetUserName());
                SqlCommand cmdDeliveryBoy = new SqlCommand(QueryDeliveryBoy, connection);
                int Rows = cmdDeliveryBoy.ExecuteNonQuery();
                connection.Close();
            }
            else if (user.GetRole() == "Worker")
            {
                connection.Open();
                string QueryWorker = string.Format("Insert into Worker(Username) Values('{0}')", user.GetUserName());
                SqlCommand cmdWorker = new SqlCommand(QueryWorker, connection);
                int Rows = cmdWorker.ExecuteNonQuery();
                connection.Close();
            }

            return true;
        }
        public static bool RemoveUser(string UserName)
        {
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("Delete from Credentials where Username = '{0}'", UserName);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();

            string Role = FindRoleByUserName(UserName);

            if (Role == "Customer")
            {
                connection.Open();
                string QueryCustomer = string.Format("Delete from Customer where Username = '{0}'", UserName);
                SqlCommand cmdCustmer = new SqlCommand(query, connection);
                int Rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
            else if (Role == "DeliveryBoy")
            {
                connection.Open();
                string QueryCustomer = string.Format("Delete from DeliveryBoy where Username = '{0}'", UserName);
                SqlCommand cmdCustmer = new SqlCommand(query, connection);
                int Rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
            else if (Role == "Worker")
            {
                connection.Open();
                string QueryCustomer = string.Format("Delete from Worker where Username = '{0}'", UserName);
                SqlCommand cmdCustmer = new SqlCommand(query, connection);
                int Rows = cmd.ExecuteNonQuery();
                connection.Close();
            }

            return true;

        }
        public static string SignIN(string UserName, string Password)
        {
            string result = "UserNotFound";

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("select Role from Credentials where Username = '{0}' and Password = '{1}' ",UserName,Password);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                result = Convert.ToString(reader["Role"]);
            }

            return result;
        }
        public static string FindRoleByUserName(string UserName)
        {
            string result = "";

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("select Role from Credentials where Username = '{0}'",UserName);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                result = Convert.ToString(reader["Role"]);
            }
            return result;
        }
    }
}
