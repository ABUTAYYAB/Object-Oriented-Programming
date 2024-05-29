using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_OOP_1.BL
{
    internal class Customer : User
    {
        private string Address;

        public Customer(string Address,User U) :base(U)
        {
            this.Address = Address;
        }

        public string GetAddress()
        {
            return this.Address;
        }
        public bool SetAddress(string Address)
        {
            this.Address = Address;
            return true;
        }
        

    }
}
