using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Interface;
using DairyDelightsLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DairyDelightsLibrary.DL.DataBase
{
    public class WorkerDL : IWorker
    {
        static WorkerDL Instance;
        private WorkerDL()
        {
        }
        public static WorkerDL GetInstance(string Connection)
        {
            if (Instance == null)
            {
                Instance = new WorkerDL();
            }
            return Instance;
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


                if (!double.TryParse(Bonus, out SalaryDouble))
                {
                    SalaryDouble = 0.0;
                }
                if (!double.TryParse(Salary, out BonusDouble))
                {
                    BonusDouble = 0.0;
                }
                User user = new User(username, FindPasswordByUserName(username), "Worker"); //object is made
                Worker worker = new Worker(user, SalaryDouble, BonusDouble, list);
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
        public string GetSalaryByUserName(string UserName)
        {
            string result = "";

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("select Salary from Worker where Username = '{0}'", UserName);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                result = Convert.ToString(reader["Salary"]);
            }
            return result;
        }
        public string GetBonusByUserName(string UserName)
        {
            string result = "";

            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("select Bonus from Worker where Username = '{0}'", UserName);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                result = Convert.ToString(reader["Bonus"]);
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
        public bool ClearComplainsByUserName(string Username)
        {
            bool Result = false;
            string Complains = "";
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("UPDATE Worker SET Complains = '{0}' WHERE Username = '{1}'", Complains, Username);
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
            string connectionString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = string.Format("SELECT Complains FROM Worker WHERE Username = '{0}'", UserName);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                result = Convert.ToString(reader["Complains"]);
            }
            reader.Close(); // Close the reader after reading
            connection.Close(); // Close the connection after usage
            return result;
        }
        public bool AddComplain(String UserName,string complain)
        {
            string UpdatedComplain = "";

            if (GetComplainsByUserName(UserName) != "")
            {
                UpdatedComplain = GetComplainsByUserName(UserName) + "%" + complain + "%";

            }
            else
            {
                UpdatedComplain = complain + "%";

            }

            bool Result = false;
            string connectiongString = Connection.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("UPDATE Worker SET Complains = '{0}' WHERE Username = '{1}'", UpdatedComplain, UserName);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                Result = true;
            }
            return Result;
        }
        public List<string> GetComplainsList(string Username)
        {
            string ComplainsInString = GetComplainsByUserName(Username);
            List<string> Complains = ConvertStringIntoComlainsList(ComplainsInString);
            return Complains;
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
