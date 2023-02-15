using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    public class SwitchCase
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_WAGE_PER_HOUR = 20;
        public void EmpWageSwitchCase()
        {
            int emphrs = 0;
            int empwage = 0;

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
            Console.WriteLine("Emp wage : " + empwage);
        
        }
    }
}
