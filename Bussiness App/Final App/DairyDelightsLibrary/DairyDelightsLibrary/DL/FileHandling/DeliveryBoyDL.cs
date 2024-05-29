using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.DL.FileHandling
{
    public class DeliveryBoyDL : iDeliveryBoy
    {
        static DeliveryBoyDL Instance;
        private DeliveryBoyDL()
        {
        }
        public static DeliveryBoyDL GetInstance(string Connection)
        {
            if (Instance == null)
            {
                Instance = new DeliveryBoyDL();
            }
            return Instance;
        }
        public bool ChangeBikeNumByUserName(string Username, string BikeNo)
        {
            throw new NotImplementedException();
        }

        public bool ChangePasswordByUserName(string Username, string Password)
        {
            throw new NotImplementedException();
        }

        public bool ChangePhoneNumByUserName(string Username, string PhoneNo)
        {
            throw new NotImplementedException();
        }

        public bool ChangeSalaryByUserName(string Username, string Salary)
        {
            throw new NotImplementedException();
        }

        public string FindPasswordByUserName(string UserName)
        {
            throw new NotImplementedException();
        }

        public string GetBikeNumberByUserName(string UserName)
        {
            throw new NotImplementedException();
        }

        public List<DeliveryBoy> GetDeliveryBoyList()
        {
            throw new NotImplementedException();
        }

        public string GetPhoneNumberByUserName(string UserName)
        {
            throw new NotImplementedException();
        }

        public string GetSalaryByUserName(string UserName)
        {
            throw new NotImplementedException();
        }
    }
}
