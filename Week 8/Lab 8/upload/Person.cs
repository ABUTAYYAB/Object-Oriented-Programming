using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    internal class Person
    {
        protected string Name, Address;
        public Person() {}
        public Person(string name,string address)
        {
            this.Name = name;
            this.Address = address;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetAddress()
        {
            return Address;
        }
        public void SetAddress(string address)
        {
            this.Address=address;
        }
        public string Tostring()
        {
            string result;
            result = $"Person[name={this.Name},address={this.Address}]";
            return result;
        }

    }
}
