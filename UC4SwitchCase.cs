using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4PPEmpWageComputation
{
    //UC4SwitchCase class
    internal class UC4SwitchCase
    {
        //method to calculate the full time and part time employee daily wages ussing the switch case
        public void empWageUsingSwitch()
        {
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

            //switch statement
            switch (empAtt)
            {
                //when the employee is present 
                case 1:
                    //Display employee is full time employee
                    Console.WriteLine("Employee is Full time");
                    //set the hour to 8
                    hour += 8;
                    //break the case 1
                    break;

                default:
                    //Display employee is part time employee
                    Console.WriteLine("Employee is Part time.");
                    //set the hour to 4
                    hour += 4;
                    //break the default case 
                    break;
            }

            //calculate the daily wage by multiplaying the hour to employee hour rate
            DailyWage = hour * EMP_HOUR_RATE;

            //Display the employee daily wage
            Console.WriteLine("Employee Daily Wage is: " + DailyWage);
        }
    }
}
