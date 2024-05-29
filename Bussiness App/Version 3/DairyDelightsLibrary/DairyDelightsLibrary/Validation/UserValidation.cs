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
        public static bool IsConvertibleToDouble(string input)
        {
            double result;
            return double.TryParse(input, out result);
        }
        public static bool IsStringValid(string input)
        {
            return !(input.Contains("%") || input.Contains(","));
        }

    }
}
