using DairyDelightsLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Validation;
using System.IO;
using DairyDelightsLibrary.Utility;
//using DairyDelightsLibrary.DL.DataBase;
using DairyDelightsLibrary.DL.FileHandling;

namespace ConsoleAppProject
{
    public class ObjectHandler
    {
        static string path = @"E:\University\semester 2\OOP\Bussiness App\Final App\ConsoleAppProject\ConsoleAppProject\bin\UserDetails.txt";

        static string Connection = "Data Source=MALIK;Initial Catalog=Final_Project;Integrated Security=True;";
        public static IUser GetUserInstance()
        {
            IUser user = UserDL.GetInstance(path);
            //IUser user = UserDL.GetInstance(Connection);

            return user;
        }
    }
}
