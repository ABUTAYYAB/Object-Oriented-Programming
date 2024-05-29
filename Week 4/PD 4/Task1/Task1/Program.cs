using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ship> list = new List<Ship>();
            while (true)
            {
                int option = menu();
                if (option == 1)
                {
                    Addship(list);
                }
                else if (option == 2)
                {
                    Viewshipposition(list);
                }
                else if (option == 3)
                {
                    serialNo(list);
                }
                else if (option == 4)
                {
                    changeposition(list);
                }
                else
                {
                    continue;
                }
            }
        }

        static int menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Ship Management System");
            Console.WriteLine("1. Add Ship");
            Console.WriteLine("2. View Ship Position");
            Console.WriteLine("3. View Ship serial number");
            Console.WriteLine("4. Change Ship Position");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());
            return choice;

        }
        static void Addship(List<Ship> list)
        {
            Ship ship = new Ship();
            Console.Write("Enter Ship Number: ");
            ship.srno = Console.ReadLine();
            ship.latitude();
            ship.longitude();
            list.Add(ship);
        }
        static void Viewshipposition(List<Ship> list)
        {
            Console.Write("Enter ship's seriel number: ");
            string str = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].srno == str)
                {
                    list[i].viewshipposition();
                }
            }
        }
        static void serialNo(List<Ship> list)
        {

            Console.WriteLine("Enter Ship Latitude:");
            Console.Write("Enter latitude Degree: ");
            int degreelatitude = int.Parse(Console.ReadLine());
            Console.Write("Enter latitude Minute: ");
            float minutelatitude = float.Parse(Console.ReadLine());
            Console.Write("Enter latitude Direction: ");
            char directionlatitude = char.Parse(Console.ReadLine());
            string shiplatitude = $"{degreelatitude}\u00b0{minutelatitude}'{directionlatitude}";

            Console.WriteLine("Enter Ship Longitude:");
            Console.Write("Enter latitude Degree: ");
            int degreelongitude = int.Parse(Console.ReadLine());
            Console.Write("Enter latitude Minute: ");
            float minutelongitude = float.Parse(Console.ReadLine());
            Console.Write("Enter latitude Direction: ");
            char directionlongitude = char.Parse(Console.ReadLine());

            string shiplongitude = $"{degreelongitude}\u00b0{minutelongitude}'{directionlongitude}";
            foreach (Ship ship in list)
            {
                if (ship.checkcoordinates(shiplatitude, shiplongitude))
                {
                    Console.WriteLine($"Ship's serial number is {ship.srno}");
                    Console.ReadLine();
                }
            }
        }
        static void changeposition(List<Ship> list)
        {
            Console.Write("Enter ship's seriel number: ");
            string str = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].srno == str)
                {
                    list[i].Changeposition();
                }
            }
        }
    }
}
