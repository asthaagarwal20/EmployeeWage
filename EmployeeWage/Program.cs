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
            int WAGE_PER_HOUR = 20;
            int FULL_DAY_HOUR = 8;
            int PART_TIME_HOUR = 8;
            int dailyEmployeeWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
            int partTimeEmployeeWage = PART_TIME_HOUR * WAGE_PER_HOUR;
            Console.WriteLine("Daily employee wage is "+dailyEmployeeWage);
            Console.WriteLine("Part time employee wage is " + partTimeEmployeeWage);
        }
    }
}
