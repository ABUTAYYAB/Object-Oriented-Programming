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
            return !(input.Contains("%") || input.Contains(",") || input.Contains("|"));
        }
        public static bool IsPhoneNumberValid(string phoneNumber)
        {
            if (phoneNumber.Length != 11)
            {
                return false;
            }
            if (phoneNumber[0] != '0')
            {
                return false;
            }
            if (phoneNumber[1] != '3')
            {
                return false;
            }
            for (int i = 2; i < phoneNumber.Length; i++)
            {
                if (!char.IsDigit(phoneNumber[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
