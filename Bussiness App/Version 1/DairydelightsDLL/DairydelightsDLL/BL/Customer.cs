using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairydelightsDLL.BL
{
    public class Customer : User
    {
        private string PhoneNumber,Address;
        public Customer(string phoneNumber, string address)
        {
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public string GetPhoneNumber()
        {
            return this.PhoneNumber;
        }
        public bool SetPhoneNumber(string PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber;
            return true;
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
