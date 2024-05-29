using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_OOP_1.BL
{
    internal class Employee : User
    {
        private double Salary,Leaves;
        private string EmployeeType;

        public Employee(double Salary,double Leaves,string EmployeeType, User u) : base(u) 
        {
            this.Salary = Salary;
            this.Leaves = Leaves;
            this.EmployeeType = EmployeeType;
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
        public double GetLeaves()
        {
            return this.Leaves;
        }
        public bool SetLeaves(double Salary)
        {
            this.Salary = Salary;
            return true;
        }
        public bool MarkLeave()
        {
            if(this.Leaves > 0) 
            {
                this.Leaves --;
                return true;

            }
            return false;
        }
    }
}
