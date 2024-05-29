using DairyDelightsLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.DL.FileHandling
{
    public class CustomerDL : ICustomer
    {
        static CustomerDL Instance;
        private CustomerDL()
        {
        }
        public static CustomerDL GetInstance(string Connection)
        {
            if (Instance == null)
            {
                Instance = new CustomerDL();
            }
            return Instance;
        }
        bool ICustomer.ChangeAddressByUserName(string Username, string Address)
        {
            throw new NotImplementedException();
        }

        bool ICustomer.ChangePhonenNumberByUserName(string Username, string PhoneNo)
        {
            throw new NotImplementedException();
        }

        bool ICustomer.CheckIfDetailsOfUserAreEntered(string UserName)
        {
            throw new NotImplementedException();
        }

        string ICustomer.GetAddressByUserName(string UserName)
        {
            throw new NotImplementedException();
        }

        string ICustomer.GetPhonenNumberByUserName(string UserName)
        {
            throw new NotImplementedException();
        }
    }
}
