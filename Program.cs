using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_RepositoryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.calculateGrossSalary();
            Console.WriteLine(obj);
            Employee obj1 = new Employee(111, "rahul", 40000);
            obj1.calculateGrossSalary();
            Console.WriteLine(obj1);
        }
    }
}
