﻿using System;
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
            int totalWage=employeeWage.ComputeWage();
            Console.WriteLine("Daily employee wage is " + totalWage) ;
        }
    }
}
