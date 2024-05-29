using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2_Challege_2.BL;

namespace Week2_Challege_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int len = 2;
            int count = 0;
            float value;
            Products[] product = new Products[len];
            while (true)
            {
                switch (Menu())
                {
                    case 1:
                        // Add a new student and store it in the data array
                        product[count] = AddProduct();
                        count++;
                        break;
                    case 2:
                        ShowProducts(product, count);
                        break;
                    case 3:
                        value = TotalWorth(product, count);
                        Console.WriteLine("the total Worth of Store is: "+value);
                        break;
                    default:
                        Console.WriteLine("Invalid Input.");
                        break;
                }
            }
        }
        static int Menu()
        {
            int num;
            Console.WriteLine("1. Add Product ");
            Console.WriteLine("2. Show Product ");
            Console.WriteLine("3. Total Store Worth ");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        static Products AddProduct()
        {
            Products products = new Products();
            Console.WriteLine("Enter the name: ");
            products.Name = Console.ReadLine();
            Console.WriteLine("Enter the ID: ");
            products.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Price: ");
            products.price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Brand name: ");
            products.BrandName = Console.ReadLine();
            Console.WriteLine("Enter the Category: ");
            products.Category = Console.ReadLine();
            Console.WriteLine("Enter the Country: ");
            products.Country = Console.ReadLine();
            return products;
        }
        static void ShowProducts(Products[] p,int count)
        {
            for(int i = 0; i < count; i++) 
            {
                Console.WriteLine(p[i].Name + "\t" + p[i].ID + "\t" + p[i].price + "\t" + p[i].BrandName + "\t" + p[i].Category + "\t" + p[i].Country);
            }
        }
        static float TotalWorth(Products[] p,int count)
        {
            float total = 0;
            for(int i = 0;i < count;i++) 
            {
                total += p[i].price;
            }
            return total;
        }
    }
}
