using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.Interface
{
     public interface ICustomer
    {
        bool CheckIfDetailsOfUserAreEntered(string UserName);
        bool ChangePhonenNumberByUserName(string Username, string PhoneNo);
        string GetPhonenNumberByUserName(string UserName);
        bool ChangeAddressByUserName(string Username, string Address);
        string GetAddressByUserName(string UserName);

    }
}
