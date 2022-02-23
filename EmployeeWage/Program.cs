using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage employeeWage = new EmployeeWage();
            int totalWageCompany1=employeeWage.ComputeWage(20,30,200);
            Console.WriteLine("Daily employee wage is for company 1" + totalWageCompany1) ;
            int totalWageCompany2 = employeeWage.ComputeWage(15, 28, 180);
            Console.WriteLine("Daily employee wage is for company 2" + totalWageCompany2);
            int totalWageCompany3 = employeeWage.ComputeWage(25, 30, 250);
            Console.WriteLine("Daily employee wage is for company 3" + totalWageCompany3);

        }
    }
}
