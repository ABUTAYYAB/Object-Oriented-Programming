using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.Utility
{
    public class Path
    {
        private static string UserFilePath = "";

        public static string GetUserFilePath()
        {
            return UserFilePath;
        }
        
        public static void SetUserFilePath(string path)
        {
            UserFilePath = path;
        }
    }
}
