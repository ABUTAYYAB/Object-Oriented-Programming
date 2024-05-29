using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.Utility
{
    public class HelpingFunctions
    {
        public static string GenerateRandomOrderID()
        {
            const string chars = "0123456789";
            Random random = new Random();
            StringBuilder stringBuilder = new StringBuilder(7);

            for (int i = 0; i < 7; i++)
            {
                stringBuilder.Append(chars[random.Next(chars.Length)]);
            }

            return stringBuilder.ToString();
        }
    }
}
