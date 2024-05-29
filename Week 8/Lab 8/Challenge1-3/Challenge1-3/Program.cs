using Challenge1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();


        }
        static void Task1()
        {
            MountainBike mountainBike = new MountainBike(1,1,1,1);
        }
        static void Task2()
        {
            Cylinder cylinder = new Cylinder();
            Cylinder cylinder1 = new Cylinder(1,1,"Blue");

        }
        static void Task3()
        {
            Staff staff = new Staff("1", "1", "1", 1234);
            Student student = new Student("1", "1", "1", 1234, 1234);

        }
    }
}
