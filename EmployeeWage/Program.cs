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
            const int WAGE_PER_HOUR = 20;
            const int FULL_DAY_HOUR = 8;
            const int PART_TIME_HOUR = 4;
            const int PRESENT = 1;
            const int ABSENT = 0;
            const int PARTIAL_PRESENT = 2;
            Random random = new Random();
            int empCheck=random.Next(0,3);
            int totalWage = 0;
            switch (empCheck)
            {
                case PARTIAL_PRESENT:
                    totalWage = PART_TIME_HOUR * WAGE_PER_HOUR;
                    break;
                case ABSENT:
                    break;
                case PRESENT:
                    totalWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
                    break;
            }
            Console.WriteLine("Daily employee wage is " + totalWage) ;
        }
    }
}
