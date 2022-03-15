using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_RepositoryDemo
{
    internal class Employee
    {
        int empId;
        string empName;
        private double empSalary, hra, da,pf,grossSalary;
        public Employee()
        {
            empId = 111;
            empName = "nilesh";
            empSalary = 34000.00f;
        }
        public Employee(int eId,string eName,float eSal)
        {
            this.empId = eId;
            this.empName = eName;
            this.empSalary = eSal;

        }
        public void CalculateGrossSalary()
        {
            hra = empSalary * 0.40;
            da = empSalary * 0.20;
            pf = empSalary * 0.12;
            grossSalary = (empSalary + hra + da) - pf;
            
        }
        public override string ToString()
        { 
            return "employee id is " + empId + "\nemployee name is " + empName + " \nemployee gross salary is " + grossSalary;

        }

    }
}
