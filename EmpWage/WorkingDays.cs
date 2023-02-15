using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    public class WorkingDays
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_WAGE_PER_HOUR = 20;
        public static int TOTAL_WORKING_DAYS = 20;
        public void EmployeeWagecheck()
        {
            int emphrs = 0;
            int empwage = 0;
            int totalempwage = 0;

            for (int day = 0; day <= TOTAL_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empcheck = random.Next(0, 3);

                switch (empcheck)
                {
                    case FULL_TIME:
                        Console.WriteLine("Employee is Present FULL_TIME");
                        emphrs = 8;
                        break;

                    case PART_TIME:
                        Console.WriteLine("Employee is Present PART_TIME");
                        emphrs = 4;
                        break;

                    default:
                        Console.WriteLine("Employee is Absent");
                        emphrs = 0;
                        break;
                }
                empwage = emphrs * EMP_WAGE_PER_HOUR;
                totalempwage += empwage;
                Console.WriteLine("Emp wage : " + empwage);
            }

            Console.WriteLine("Total Emp wage : " + totalempwage);
        }
    }
}
