using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_RepositoryDemo
{
    // we are achieving inheritance in the following programm.
    public class Manager:Employee
    {
        private double foodAllowance, travellAllowance;
        public Manager() : base()// we are calling base class constructor here
        {
            foodAllowance = 0.0;
            travellAllowance = 0.0;
        }
        public Manager(int eId, string eName, float eSal,double foodAl,double travAll):base(eId,eName,eSal)
        {
            this.foodAllowance = foodAl;
            this.travellAllowance = travAll; ;
          
        }
        public override void CalculateGrossSalary()
        {
            hra = empSalary * 0.40;
            da = empSalary * 0.20;
            pf = empSalary * 0.12;
            grossSalary = (empSalary + hra + da+foodAllowance+travellAllowance) - pf;
        }
        public override string ToString()
        {
            return "employee id is " + empId + "\nemployee name is " + empName + " \nemployee gross salary is " + grossSalary;

        }

    }
}
