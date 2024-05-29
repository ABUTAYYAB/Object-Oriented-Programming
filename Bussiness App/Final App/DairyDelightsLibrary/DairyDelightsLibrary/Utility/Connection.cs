using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.Utility
{
    public class Connection
    {
        private static string ConnectionString = "Data Source=MALIK;Initial Catalog=Final_Project;Integrated Security=True;";

        public static string GetConnectionString()
        {
            return ConnectionString;
        }
        public static void SetConnectionString(string connection)
        {
            ConnectionString = connection;
        }
    }
}
