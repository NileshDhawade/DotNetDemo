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
            obj.CalculateGrossSalary();
            Console.WriteLine(obj);
            Console.WriteLine("\n==========================================\n");
            Employee obj1 = new Employee(111, "rahul", 40000);
            obj1.CalculateGrossSalary();
            Console.WriteLine(obj1);
            Console.WriteLine("\n=========================================\n");
            Manager mn = new Manager();
            mn.CalculateGrossSalary();
            Console.WriteLine(mn);
            Console.WriteLine("\n========================================\n");
            Manager mn1 = new Manager(121, "ram", 45000, 1000, 2000);
            mn1.CalculateGrossSalary();
            Console.WriteLine(mn1);

            Console.WriteLine("\n==========================================\n");

            SalesManager sm = new SalesManager(444, "abhishek", 49000, 3000, 2000, 800);
            sm.CalculateGrossSalary();
            Console.WriteLine(sm);


        }
    }
}
