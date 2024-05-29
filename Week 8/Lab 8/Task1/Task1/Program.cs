using hostelliteTASK.BL;
using System;

namespace hostelliteTASK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hostellite();
            Dayscholar();
        }
        static void Hostellite()
        {

            Hostelite std = new Hostelite();

            std.name = "Ahmad";

            std.RoomNumber = 12;

            Console.WriteLine(std.name + " is Allocated Room" + std.RoomNumber);


            Console.ReadKey();
        }
        static void Dayscholar()
        {
            DayScholar std = new DayScholar();

            std.name = "Ahmad";

            std.busNo = 1;

            Console.WriteLine(std.name + " is Allocated Bus" + std.busNo);

            Console.ReadKey();

        }
    }
}
