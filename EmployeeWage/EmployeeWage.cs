﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeWage
    {
        public int ComputeWage()
        {
            const int WAGE_PER_HOUR = 20;
            const int FULL_DAY_HOUR = 8;
            const int PART_TIME_HOUR = 4;
            const int PRESENT = 1;
            const int ABSENT = 0;
            const int PARTIAL_PRESENT = 2;
            int day = 0;
            Random random = new Random();
            int totalWage = 0;
            int totalWorkingHours = 0;
            while (day < 20 && totalWorkingHours < 100)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case PARTIAL_PRESENT:
                        totalWage += PART_TIME_HOUR * WAGE_PER_HOUR;
                        totalWorkingHours += PART_TIME_HOUR;
                        break;
                    case ABSENT:
                        break;
                    case PRESENT:
                        totalWage += WAGE_PER_HOUR * FULL_DAY_HOUR;
                        totalWorkingHours += FULL_DAY_HOUR;
                        break;
                }
                day++;
            }
            return totalWage;
        }
    }
}
