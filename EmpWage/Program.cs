﻿using System;
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

            SwitchCase switchcase = new SwitchCase();
            switchcase.EmpWageSwitchCase();
            Console.ReadLine();


        }
    }
}
