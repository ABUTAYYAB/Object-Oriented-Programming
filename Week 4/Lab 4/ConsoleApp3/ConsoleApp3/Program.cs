using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.BL;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer("hghet","kuuwhgfhiuerhgiu","uehfiuewrrhfiu");
            List<Product> p = new List<Product>();

            for(int i = 0; i < 1; i++) 
            {
                c.addProduct();
            }
            p = c.getAllProducts();

            for (int i = 0; i < 3; i++)
            {
            Console.WriteLine(p);

            }
            Console.ReadLine();

        }
    }
}
