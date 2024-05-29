using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using test.Class;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght;
            Console.Write("Enter How many time You want to enter data :");
            lenght = int.Parse(Console.ReadLine()); 

            Putabaz [] array = new Putabaz[lenght];

            for(int i = 0; i < lenght; i++) 
            {
                array[i] = getData(i+1);
                Console.Write("\n");

            }
            print_Data(array, lenght);
            Console.ReadKey();
        }
        static Putabaz getData(int id)
        {
            string name;
            int age;
            string gender;
            Console.Write("Enter Name:");
            name = Console.ReadLine();
            Console.Write("Enter Age:");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter Gender:");
            gender = Console.ReadLine();
            
            Putabaz p = new Putabaz(name,age,gender,id);

            return p;

        }
        static void print_Data(Putabaz[] array, int len)
        {
            Console.Clear();
            for(int i = 0; i < len; i++)
            {
               
                Console.WriteLine("name is : {0}", array[i].name);
                Console.WriteLine("Age is : {0}", array[i].age);
                Console.WriteLine("Gender is : {0}", array[i].gender);
                Console.WriteLine("ID is : {0}", array[i].id);

            }

        }

    }
        
}
