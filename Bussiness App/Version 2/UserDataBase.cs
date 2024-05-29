using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DairyDelightsLibrary.DL.DataBase
{
    public class UserDataBase
    {
        public static List<User> UsersList = new List<User>();
        public static bool LoadDataFromDataBase()
        {
            bool Result = false;

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

                User user = new User(username,password,role); //object is made
                if(role == "Admin")
                {
                    Admin admin = new Admin(user);
                    UsersList.Add(admin);
                }
                else if(role == "Worker")
                {
                    Worker worker = new Worker(user);
                    UsersList.Add(worker);
                }
                else if (role == "DeliveyBoy")
                {
                    DeliveryBoy deliveryBoy = new DeliveryBoy(user);
                    UsersList.Add(deliveryBoy);
                }
                else if (role == "Customer")
                {
                    Customer customer = new Customer(user);
                    UsersList.Add(customer);
                }
            }
            connection.Close();

            Result = true;
            Result = GetWorkerDetails();
            return Result;

        }

        public static bool GetWorkerDetails()
        {
            bool result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string Query = string.Format("select * from Worker");
            SqlCommand Command = new SqlCommand(Query, connection);
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {
                string Username = Convert.ToString(reader["Username"]);
                string SalaryString = Convert.ToString(reader["Salary"]);
                string BonusString = Convert.ToString(reader["Bonus"]);
                string ComplainsCombined = Convert.ToString(reader["Complains"]);
                double Salary = double.Parse(SalaryString);
                double Bonus = double.Parse(BonusString);


                for (int i = 0;i < UsersList.Count; i++)
                {
                    if(Username == UsersList[i].GetUserName())
                    {
                        Worker worker = (Worker)UsersList[i];
                        worker.SetComplainsList(ConvertArrayIntoList(ComplainsCombined));
                        worker.SetBonus(Bonus);
                        worker.SetSalary(Salary);
                    }
                }
            }
            result = true;
            return result;
        }
        public static List<string> ConvertArrayIntoList(string String)
        {
            string[] Array = String.Split('%');
            List<string> list = new List<string>();
            for(int i = 0; i < Array.Length; i++) 
            {
                list.Add(Array[i]);
            }

            return list;

        }

        //public static bool AddUser(User user)
        //{
        //    string connectiongString = Connection.GetConnectionString();
        //    SqlConnection connection = new SqlConnection(connectiongString);
        //    connection.Open();

        //    string query = string.Format("Insert into Credentials(Username,Password,Role) Values('{0}', '{1}', '{2}')", user.GetUserName(), user.GetPassword(), user.GetRole());
        //    SqlCommand cmd = new SqlCommand(query, connection);
        //    int rows = cmd.ExecuteNonQuery();
        //    connection.Close();

        //    if (user.GetRole() == "Customer")
        //    {
        //        connection.Open();
        //        string QueryCustomer = string.Format("Insert into Customer(Username) Values('{0}')", user.GetUserName());
        //        SqlCommand cmdCustmer = new SqlCommand(query, connection);
        //        int Rows = cmd.ExecuteNonQuery();
        //        connection.Close();
        //    }
        //    else if (user.GetRole() == "DeliveryBoy")
        //    {
        //        connection.Open();
        //        string QueryCustomer = string.Format("Insert into DeliveryBoi(Username) Values('{0}')", user.GetUserName());
        //        SqlCommand cmdCustmer = new SqlCommand(query, connection);
        //        int Rows = cmd.ExecuteNonQuery();
        //        connection.Close();
        //    }
        //    else if (user.GetRole() == "Worker")
        //    {
        //        connection.Open();
        //        string QueryCustomer = string.Format("Insert into Worker(Username) Values('{0}')", user.GetUserName());
        //        SqlCommand cmdCustmer = new SqlCommand(query, connection);
        //        int Rows = cmd.ExecuteNonQuery();
        //        connection.Close();
        //    }

        //    UsersList.Add(user);
        //    return true;
        //}
        //public static bool RemoveUser(User user)
        //{
        //    string connectiongString = Connection.GetConnectionString();
        //    SqlConnection connection = new SqlConnection(connectiongString);
        //    connection.Open();

        //    string query = string.Format("Delete from Credentials where Username = '{0}'", user.GetUserName());
        //    SqlCommand cmd = new SqlCommand(query, connection);
        //    int rows = cmd.ExecuteNonQuery();
        //    connection.Close();

        //    if (user.GetRole() == "Customer")
        //    {
        //        connection.Open();
        //        string QueryCustomer = string.Format("Delete from Customer where Username = '{0}'", user.GetUserName());
        //        SqlCommand cmdCustmer = new SqlCommand(query, connection);
        //        int Rows = cmd.ExecuteNonQuery();
        //        connection.Close();
        //    }
        //    else if (user.GetRole() == "DeliveryBoy")
        //    {
        //        connection.Open();
        //        string QueryCustomer = string.Format("Delete from DeliveryBoy where Username = '{0}'", user.GetUserName());
        //        SqlCommand cmdCustmer = new SqlCommand(query, connection);
        //        int Rows = cmd.ExecuteNonQuery();
        //        connection.Close();
        //    }
        //    else if (user.GetRole() == "Worker")
        //    {
        //        connection.Open();
        //        string QueryCustomer = string.Format("Delete from Worker where Username = '{0}'", user.GetUserName());
        //        SqlCommand cmdCustmer = new SqlCommand(query, connection);
        //        int Rows = cmd.ExecuteNonQuery();
        //        connection.Close();
        //    }

        //    UsersList.Remove(user);
        //    return true;

        //}
        //public static bool UpdatePassword(string UserName, string Password)
        //{
        //    bool result = false;

        //    string connectiongString = Connection.GetConnectionString();
        //    SqlConnection connection = new SqlConnection(connectiongString);
        //    connection.Open();

        //    string query = string.Format("update Credentials set Password ={0}where Username ={1}", Password, UserName);
        //    SqlCommand cmd = new SqlCommand(query, connection);
        //    int rows = cmd.ExecuteNonQuery();
        //    connection.Close();
        //    if (rows > 0)
        //    {
        //        result = UpdatePasswordInList(UserName, Password);
        //    }
        //    return result;

        //}
        //public static bool UpdatePasswordInList(string UserName, string Password)
        //{
        //    bool result = false;
        //    foreach (User u in UsersList)
        //    {
        //        if (u.GetUserName() == UserName)
        //        {
        //            u.SetPassword(Password);
        //            result = true;
        //        }
        //    }

        //    return result;
        //}
        //public static string SignUP(User user)
        //{
        //    string result = "";

        //    string connectiongString = Connection.GetConnectionString();
        //    SqlConnection connection = new SqlConnection(connectiongString);
        //    connection.Open();

        //    string query = string.Format("select Roll from Credentials where Username = '{0}' and Password = '{1}' ", user.GetUserName(), user.GetPassword());
        //    SqlCommand cmd = new SqlCommand(query, connection);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    //int rows = cmd.ExecuteNonQuery();
        //    //connection.Close();

        //    if (reader.Read())
        //    {
        //        result = Convert.ToString(reader["Roll"]);
        //    }

        //    return result;
        //}
    }
}
