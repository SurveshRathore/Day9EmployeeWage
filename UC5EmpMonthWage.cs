using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4PPEmpWageComputation
{
    internal class UC5EmpMonthWage
    {
        //method to calculate the monthly wage of an employee 
        public void calcMonthWage()
        {
            //set 1 for the full time employee
            int IS_FULL_TIME = 1;
            //variable to store the employee hourly rate
            int EMP_HOUR_RATE = 80;
            //variable to set the days per month
            int EMP_MONTH_DAYS = 20;
            //variable to store the hour
            int hour = 0;
            //variable to store the employee monthly wage
            int MonthlyWage = 0;

            //Create an object of the Random() class
            Random random = new Random();

            //call the Next() function of the random class with the value 0 and 2
            int empAtt = random.Next(0, 2);

            //when the employee is present 
            if (empAtt == IS_FULL_TIME)
            {
                //Display employee is full time employee
                Console.WriteLine("Employee is Full time");
                //set the hour to 8
                hour += 8;
            }
            else
            {
                //Display employee is part time employee
                Console.WriteLine("Employee is Part time.");
                //set the hour to 4
                hour += 4;
            }
            //calculate the monthly wage by multiplaying the hour to employee hour rate and month days
            MonthlyWage = hour * EMP_HOUR_RATE * EMP_MONTH_DAYS;

            //Display the employee monthly wage
            Console.WriteLine("Employee Monthly Wage is: " + MonthlyWage);
        }
    }
}
