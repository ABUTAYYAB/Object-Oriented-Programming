using DairyDelightsLibrary.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.Interface
{
    public interface iDeliveryBoy
    {
        List<DeliveryBoy> GetDeliveryBoyList();
        bool ChangePasswordByUserName(string Username, string Password);
        string FindPasswordByUserName(string UserName);
        bool ChangeSalaryByUserName(string Username, string Salary);
        bool ChangeBikeNumByUserName(string Username, string BikeNo);
        bool ChangePhoneNumByUserName(string Username, string PhoneNo);

        string GetSalaryByUserName(string UserName);
        string GetBikeNumberByUserName(string UserName);
        string GetPhoneNumberByUserName(string UserName);


    }
}
