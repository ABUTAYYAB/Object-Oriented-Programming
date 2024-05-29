using DairyDelightsLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.Validation
{
    public class UserValidation
    {
        public static bool CheckIfUserNameAlreadyExist(string UserName)
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
    }
}
