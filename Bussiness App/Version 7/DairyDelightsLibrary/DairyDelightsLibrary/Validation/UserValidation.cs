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
            /*// Check if the input string is null or empty
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            // Check if the input string contains only valid characters
            foreach (char c in input)
            {
                if (!char.IsDigit(c) && c != '.' && c != 'e' && c != 'E' && c != '+' && c != '-')
                {
                    return false;
                }
            }*/

            // Check if the input string can be parsed to a double
            double result;
            if (!double.TryParse(input, out result))
            {
                return false;
            }

            // Check if the parsed result is positive
            if (result >= 0)
            {
                return true;
            }

            return false;
        }

        /*public static bool IsConvertibleToDouble(string input)
        {
            double result;
            if (double.TryParse(input, out result))
            {
                return result >= 0; // Return false if the number is negative
            }
            return false; // Return false if parsing fails
        }*/
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

    }
}
