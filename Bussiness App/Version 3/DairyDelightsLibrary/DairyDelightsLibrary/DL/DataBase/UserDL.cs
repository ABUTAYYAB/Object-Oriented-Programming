using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Utility;
using DairyDelightsLibrary.Interface;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.DL.DataBase
{
    public class UserDL :IUser
    {
        public static string ActiveUser;
        static UserDL Instance;
        private UserDL(string Connection) 
        {
            Utility.Connection.SetConnectionString(Connection);

        }
        public static UserDL GetInstance(string Connection) 
        {
            if(Instance == null)
            {
                Instance = new UserDL(Connection);
            }
            return Instance;
        }

        public  bool SignUP(User user) 
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
                string QueryDeliveryBoy = string.Format("Insert into DeliveryBoy(Username) Values('{0}')", user.GetUserName());
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
        public  bool RemoveUser(string UserName)
        {
            bool check = false;
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
            if (rows > 0)
            {
                check = true;
            }
                return check;
        }
        public  string SignIN(string UserName, string Password)
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
                ActiveUser = UserName;
            }

            return result;
        }
        public  string FindRoleByUserName(string UserName)
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

        public bool CheckIfUserNameAlreadyExist(string UserName)
        {
            string result = "";
            bool check = true;

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("select Role from Credentials where Username = '{0}'", UserName);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                result = Convert.ToString(reader["Role"]);
            }
            if (result == "")
            {
                check = false;
            }
            return check;
        }
        public bool ChangePassword(string Password)
        {
            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("UPDATE Credentials SET Password = '{0}' WHERE Username = '{1}'", Password, ActiveUser);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if(rows > 0) 
            {
                Result = true;
            }
            return Result;

        }
        public bool ChangePasswordByUserName(string Username,string Password)
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
        public List<User> GetUsersList()
        {
            List<User> users = new List<User>();
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string Query = string.Format("select * from Credentials");
            SqlCommand Command = new SqlCommand(Query, connection);
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {
                string username = Convert.ToString(reader["Username"]);
                string password = Convert.ToString(reader["Password"]);
                string role = Convert.ToString(reader["Role"]);

                User user = new User(username, password, role); //object is made
                users.Add(user);
            }
            connection.Close();
            return users;

        }
        

    }
}
