using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_RepositoryDemo
{
    public class Employee_StaticVariableAndMethod
    {
        static int count;
        protected int empId;
        protected string empName;
        protected double empSalary, hra, da, pf, grossSalary;
        public Employee_StaticVariableAndMethod()
        {
            
            empName = "nilesh";
            empSalary = 34000.00f;
        }
        public Employee_StaticVariableAndMethod( string eName, double eSal)
        {
            count++;
            empId = count;
            this.empName = eName;
            this.empSalary = eSal;

        }
        public  void CalculateGrossSalary()
        {
            hra = empSalary * 0.40;
            da = empSalary * 0.20;
            pf = empSalary * 0.12;
            grossSalary = (empSalary + hra + da) - pf;

        }
        public static int Getcount()
        {
            return count;
        }
        public override string ToString()
        {
            return "employee id is " + empId + "\nemployee name is " + empName + " \nemployee gross salary is " + grossSalary;

        }

    }
}

