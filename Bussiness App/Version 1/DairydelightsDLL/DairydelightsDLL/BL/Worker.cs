using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairydelightsDLL.BL
{
    public class Worker : User
    {
        private double Salary, Bonus;
        private List<string> ComplainsList;

        public Worker(double salary, double bonus)
        {
            this.Salary = salary;
            this.Bonus = bonus;
            ComplainsList = new List<string>();
        }
        public Worker(string UserName, string Password, string Role,double salary) :base(UserName, Password,Role) 
        {
            this.Salary = salary;
            ComplainsList = new List<string>();
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
        public double GetBonus()
        {
            return this.Bonus;
        }
        public bool SetBonus(double Salary)
        {
            this.Salary = Salary;
            return true;
        }
        public bool AddComplain(string Complain)
        {
            ComplainsList.Add(Complain);
            return true;
        }
        public bool RemoveComplain(int number)     //it will remove only the sppecified Complain
        {
            ComplainsList.RemoveAt(number);
            return true;
        }
        public bool RemoveAllComplains()
        {
            ComplainsList.Clear();
            return true;
        }
        public List<string> GetComplainsList()
        {
            return this.ComplainsList;
        }
        public bool SetComplainsList(List<string> complainsList)
        {
            this.ComplainsList = complainsList;
            return true;
        }
        public string GetComplainsInString()
        {
            string complain = "";
            for(int i = 0;i < ComplainsList.Count;i++) 
            {
                complain = complain + ComplainsList[i] +"%";
            }

            return complain;

        }
    }
}
