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
    public class WorkerDL : IWorker
    {
        static WorkerDL Instance;
        private WorkerDL()
        {
        }
        public static WorkerDL GetInstance()
        {
            if (Instance == null)
            {
                Instance = new WorkerDL();
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
        public List<Worker> GetWorkerList()
        {
            List<Worker> workers = new List<Worker>();

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string Query = string.Format("select * from Worker");
            SqlCommand Command = new SqlCommand(Query, connection);
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {
                string username = Convert.ToString(reader["Username"]);
                string Salary = Convert.ToString(reader["Salary"]);
                string Bonus = Convert.ToString(reader["Bonus"]);
                string Complains = Convert.ToString(reader["Complains"]);
                List<string> list = ConvertStringIntoComlainsList(Complains);
                double SalaryDouble,BonusDouble;

                User user = new User(username, FindPasswordByUserName(username), "Worker"); //object is made
                Worker worker = new Worker(user, double.Parse(Salary), double.Parse(Bonus), list);

                workers.Add(worker);
            }


            connection.Close();
            return workers;

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
        public bool ChangeSalaryByUserName(string Username, string Salary)
        {
            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("UPDATE Worker SET Salary = '{0}' WHERE Username = '{1}'",Salary, Username);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Result = true;
            }
            return Result;

        }
        public bool ChangeBonusByUserName(string Username, string Bonus)
        {
            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("UPDATE Worker SET Bonus = '{0}' WHERE Username = '{1}'", Bonus, Username);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Result = true;
            }
            return Result;

        }
        public bool ChangeComplainsByUserName(string Username, string Complains)
        {
            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("UPDATE Worker SET Comlains = '{0}' WHERE Username = '{1}'", Complains, Username);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Result = true;
            }
            return Result;

        }
        public string GetComplainsByUserName(string UserName)
        {
            string result = "";

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("select Complains form Worker where Username = '{0}'", UserName);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                result = Convert.ToString(reader["Complains"]);
            }
            return result;
        }
        public static List<string> ConvertStringIntoComlainsList(string String)
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
