﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empwage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Employee Wage Program");
          
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random= new Random();
            int empCheck = random.Next(0,2);
            if(empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs= 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("EmpWage : " + empWage);
           Console.ReadLine();
        }
    }
}
