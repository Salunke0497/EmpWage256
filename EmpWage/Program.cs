using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC1 for check employee present or not
            //EmpCheck obj= new EmpCheck();
            //obj.AttendanceCheck();
            //Console.ReadLine();

            //UC2 check Daily emp wage
            //DailyWage dailyWage = new DailyWage();
            //dailyWage.DailyWageCheck();
            //Console.ReadLine();


            //check part time employee check
            PartTimeEmpWage obj =new PartTimeEmpWage();
            obj.PartTimeEmpCheck();
            Console.ReadLine();

        }
    }
}
