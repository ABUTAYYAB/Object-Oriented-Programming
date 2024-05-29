using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX.BL
{
    internal class Ship
    {
        public Ship(string sname, string owner, string driver, string destination) 
        {
            this.sname = sname;
            this.owner = owner;
            this.driver = driver;
            this.destination = destination;
        }
        string sname, owner, driver,destination;
        List <Person> persons = new List<Person>();
    }
}
