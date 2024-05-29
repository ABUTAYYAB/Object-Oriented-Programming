using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.Utility
{
    public class Path
    {
        private static string UserFilePath = @"E:\University\semester 2\OOP\Bussiness App\Bussiness App Final\ConsoleAppProject\ConsoleAppProject\bin\UserDetails.txt";

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
