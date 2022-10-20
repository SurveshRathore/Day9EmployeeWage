using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10EmpWage
{
    internal class UC8EmpWageMultipleComp
    {
        //variable to store the hour
        int hour = 0;
        //variable to count the days
        int days = 0;
        //variable to store the employee monthly wage
        int MonthlyWage = 0;

        //Create an object of the Random() class
        Random random = new Random();

        public void calcEmpWage(string companyName, int EMP_HOUR_RATE, int EMP_MONTH_HOURS, int EMP_MONTH_DAYS)
        {
            while (hour <= EMP_MONTH_HOURS && days < EMP_MONTH_DAYS)
            {
                //call the Next() function of the random class with the value 0 and 2
                int empAtt = random.Next(0, 3);

                //switch statement
                switch (empAtt)
                {
                    //when the employee is present for full time 
                    case 1:
                        //set the hour to 8
                        hour += 8;
                        //increase the days by 1
                        days++;
                        //Display employee is present for full time
                        Console.WriteLine("Employee is present for Full time. Hours = {0}, Days = {1}", hour, days);

                        //break the case 1
                        break;
                    //when the employee is present for part time
                    case 2:
                        //set the hour to 4
                        hour += 4;
                        //increase the days by 1
                        days++;
                        //Display employee present for part time
                        Console.WriteLine("Employee is present for part time. Hours = {0}, Days = {1}", hour, days);

                        //break the case 2
                        break;

                    default:
                        //increase the days by 1
                        days++;
                        //Display employee is part time employee
                        Console.WriteLine("Employee is Absent. Hours = {0}, Days = {1}", hour, days);

                        //break the default case 
                        break;
                }
            }
            //calculate the monthly wage by multiplaying the hour to employee hour rate and month days
            MonthlyWage = hour * EMP_HOUR_RATE * EMP_MONTH_DAYS;

            //Display the employee monthly wage
            Console.WriteLine("Employee Monthly Wage for company {0} is: {1}",companyName, MonthlyWage);
        }
    }
}
