using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.BL
{

    public class DeliveryBoy : User
    {

        private string BikeNumber;
        private string PhoneNumber;
        private double Salary;

        public DeliveryBoy(User user):base(user)
        {

        }

        public DeliveryBoy(string BikeNumber, string PhoneNumber)
        {
            this.BikeNumber = BikeNumber;
            this.PhoneNumber = PhoneNumber;
        }

        public double GetSalary()
        {
            return this.Salary;
        }
        public bool SetSalary(double Salary)
        {
            this.Salary = Salary;
            return true;
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
