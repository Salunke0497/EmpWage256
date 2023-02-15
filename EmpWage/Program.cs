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
            //EmpCheck obj= new EmpCheck();
            //obj.AttendanceCheck();
            //Console.ReadLine();

            //DailyWage dailyWage = new DailyWage();
            //dailyWage.DailyWageCheck();
            //Console.ReadLine();

            //PartTime partTime = new PartTime();
            //partTime.PartTimeEmpWage();
            //Console.ReadLine();

            //SwitchCase switchcase = new SwitchCase();
            //switchcase.EmpWageSwitchCase();
            //Console.ReadLine();

            //WorkingDays workingDays = new WorkingDays();
            //workingDays.EmployeeWagecheck();
            //Console.ReadLine();

            //UC6WorkingDays workingDays = new UC6WorkingDays();
            //workingDays.EmpWage100Days();

            UC7EmpWage EmpWage = new UC7EmpWage();
            EmpWage.ComputeEmpWage();
            Console.ReadLine();
        }
    }
}
