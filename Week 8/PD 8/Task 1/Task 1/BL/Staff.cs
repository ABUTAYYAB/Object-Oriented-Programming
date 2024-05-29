using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.BL
{
    internal class Staff : Person
    {
        private string School;
        private double Pay;
        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            this.Pay = pay;
            this.School = school;
        }
        public string GetSch()
        {
            return this.School;
        }
        public double GetPay()
        {
            return Pay;
        }
        public void SetSch(string school)
        {
            this.School = school;
        }
        public void SetPay(double pay)
        {
            this.Pay = pay;
        }
        public new string Tostring()
        {
            string result;
            result = $"[Person[name={this.Name},address={this.Address}],school={this.School},pay={this.Pay}]";
            return result;
        }
    }
}
