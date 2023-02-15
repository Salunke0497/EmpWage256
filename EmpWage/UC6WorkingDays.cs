using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    public class UC6WorkingDays
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_WAGE_PER_HOUR = 20;
        public static int TOTAL_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        public void EmpWage100Days()
        {
            int emphrs = 0;
            int totalemphrs = 0;
            int totalworkingdays = 0;
            while (totalemphrs <= MAX_HRS_IN_MONTH && totalworkingdays <= TOTAL_WORKING_DAYS)
            {
                totalworkingdays++;
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
                totalemphrs += emphrs;
                Console.WriteLine("Days : " + totalworkingdays + "Emp Hrs : " + emphrs);
            }
            int totalempwage = emphrs * EMP_WAGE_PER_HOUR;
            Console.WriteLine("Total Emp wage : " + totalempwage);
        }
    }
}
