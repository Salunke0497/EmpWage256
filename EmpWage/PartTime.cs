using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    public class PartTime
    {
        public void PartTimeEmpWage()
        {
            int FULL_TIME = 1;
            int PART_TIME = 2;
            int EMP_WAGE_PER_HOUR = 20;

            int emphrs = 0;
            int empwage = 0;

            Random random = new Random();
            int empcheck = random.Next(0, 3);

            if (empcheck == FULL_TIME)
            {
                Console.WriteLine("employee is Present FULL_TIME");
                emphrs = 8;
            }
            else if (empcheck == PART_TIME)
            {
                Console.WriteLine("Employee is Present for PART_TIME");
                emphrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                emphrs = 0;
            }
            empwage = emphrs * EMP_WAGE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empwage);
        }
    }
}
