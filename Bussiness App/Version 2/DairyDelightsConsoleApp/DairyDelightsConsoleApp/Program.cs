using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DairyDelightsLibrary.DL.DataBase;
using DairyDelightsLibrary.BL;


namespace DairyDelightsConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result = UserDataBase.LoadDataFromDataBase();

        }
    }
}
