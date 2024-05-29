using DairyDelightsLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.Validation
{
    public class UserValidation
    {
        public static bool IsConvertibleToDouble(string input)
        {
            

            if (double.TryParse(input, out double result))
            {
                if (result >= 0)
                {
                    return true;
                }
            }
            return false;
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
        public static double ConvertStringIntoDouble(string  input)
        {
            double result;
            if (!double.TryParse(input, out result))
            {
                result = 0.0;
            }
            return result;
        }
        public static bool IsDiscountValid(string input)
        {
            if (float.TryParse(input, out float discount))
            {
                if (discount >= 0 && discount <= 100)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
