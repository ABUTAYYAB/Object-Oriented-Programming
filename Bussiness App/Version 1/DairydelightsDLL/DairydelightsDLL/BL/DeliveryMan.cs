using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairydelightsDLL.BL
{
    public class DeliveryMan
    {
        private string BikeNumber;
        private string PhoneNumber;

        public DeliveryMan(string BikeNumber, string PhoneNumber)
        {
            this.BikeNumber = BikeNumber;
            this.PhoneNumber = PhoneNumber;
        }

        public string GetBikeNumber()
        {
            return this.BikeNumber;
        }
        public bool SetBikeNumber(string BikeNumber)
        {
            this.BikeNumber = BikeNumber;
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
    }
}
