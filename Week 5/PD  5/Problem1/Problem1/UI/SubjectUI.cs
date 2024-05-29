using Problem1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.UI
{
    internal class SubjectUI
    {
        public static void AddSubject()
        {
            Console.WriteLine("Enter Subject Code: ");
            string Code = Console.ReadLine();
            Console.WriteLine("Enter Subject Type: ");
            string Type = Console.ReadLine();
            Console.WriteLine("Enter Subject Credit Hours: ");
            int CreditHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Fee: ");
            int Fee = int.Parse(Console.ReadLine());

            Subject s = new Subject(Code, CreditHours, Type, Fee);
        }
    }
}
