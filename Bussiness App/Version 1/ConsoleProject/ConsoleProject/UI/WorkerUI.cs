using DairydelightsDLL.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.UI
{
    internal class WorkerUI
    {
        public static double EnterSalary()
        {
            Console.Write("Enter the Price of the product: ");
            double price = double.Parse(Console.ReadLine());
            return price;
        }
        public static Worker MakeWorker()
        {
            Worker u = new Worker(UserUI.EnterID(), UserUI.EnterPassword(), UserUI.EnterRole(),EnterSalary());
            return u;
        }
    }
}
