using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_RepositoryDemo
{
    internal class SalesManager:Employee
    {
        private double travellingAllowance;
        private double foodAllowance;
        private double commission;

        public SalesManager() :base()
        {
            travellingAllowance = 0.0;
            foodAllowance = 0.0;
            commission = 0.0;
        }
        public SalesManager(int eId, string eName, double eSal,double travall,double foodall,double comm):base(eId,eName,eSal)
        {
            this.travellingAllowance = travall;
            this.foodAllowance = foodall;
            this.commission = comm;

        }public override void CalculateGrossSalary()
        {
            hra = empSalary * 0.40;
            da = empSalary * 0.20;
            pf = empSalary * 0.12;
            grossSalary = (empSalary + hra + da+travellingAllowance+foodAllowance+commission) - pf;
        }
        public override string ToString()
        {
            return "employee id is " + empId + "\nemployee name is " + empName + " \nemployee gross salary is " + grossSalary;

        }


    }
}
