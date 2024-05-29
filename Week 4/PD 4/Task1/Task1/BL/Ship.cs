using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Ship
    {
        public Ship()
        {

        }

        public string srno;
        Angle Latitudes = new Angle();
        Angle Longitudes = new Angle();


        public void latitude()
        {
            Console.WriteLine("Enter Ship's Latitude: ");
            Console.Write("Enter degrees:");
            Latitudes.degrees = int.Parse(Console.ReadLine());
            Console.Write("Enter minutes:");
            Latitudes.minutes = float.Parse(Console.ReadLine());
            Console.Write("Enter direction:");
            Latitudes.direction = char.Parse(Console.ReadLine());
        }

        public void longitude()
        {
            Console.WriteLine("Enter Ship's Longitude: ");
            Console.Write("Enter degrees:");
            Longitudes.degrees = int.Parse(Console.ReadLine());
            Console.Write("Enter minutes:");
            Longitudes.minutes = float.Parse(Console.ReadLine());
            Console.Write("Enter direction:");
            Longitudes.direction = char.Parse(Console.ReadLine());
        }
        public void viewshipposition()
        {
            Console.WriteLine($"Ship is at {Latitudes.viewangle()} and {Longitudes.viewangle()}");
            Console.Read();
        }
        public bool checkcoordinates(string lati, string longi)
        {
            if (lati == Latitudes.viewangle() && longi == Longitudes.viewangle())
            {
                return true;
            }
            return false;
        }

        public void Changeposition()
        {
            latitude();
            longitude();
        }
    }
}
