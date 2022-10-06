using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4PPEmpWageComputation
{
    //UC2EmpDailyWage class
    internal class UC3PartTimeEmpWage
    {
        //method to calculate the full time and part time employee daily wages
        public void CalcPartTimeEmpWage ()
        {
            //set 1 for the full time employee
            int IS_FULL_TIME = 1;
            //variable to store the employee hourly rate
            int EMP_HOUR_RATE = 80;
            //variable to store the hour
            int hour = 0;
            //variable to store the employee daily wage
            int DailyWage = 0;
            
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
            //calculate the daily wage by multiplaying the hour to employee hour rate
            DailyWage = hour * EMP_HOUR_RATE;

            //Display the employee daily wage
            Console.WriteLine("Employee Daily Wage is: " + DailyWage);
        }
    }
}
