using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.BL
{
    public class Customer : User
    {
        private string PhoneNumber, Address;
        private Cart CartUser;

        public Customer(User user): base(user)
        {
            PhoneNumber = "";
            Address = "";
            Cart CartUser = new Cart();
        }
        public Customer(string user, string phoneNumber, string address) : base(user)
        {
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            Cart CartUser = new Cart();
        }
        public Customer(string phoneNumber, string address)
        {
            PhoneNumber = phoneNumber;
            Address = address;
        }
        public Customer(string phoneNumber, string address,Cart cart)
        {
            PhoneNumber = phoneNumber;
            Address = address;
            Cart CartUser = new Cart(cart);

        }
        public Cart GetCart()
        {
            return this.CartUser;
        }
        public bool SetCart(Cart cart)
        {
            this.CartUser = cart;
            return true;
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
