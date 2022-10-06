using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day4PPEmpWageComputation;

namespace Day4PPEmpWageComputation
{
    //UC2EmpDailyWage class
    internal class UC2EmpDailyWage
    {
        //variable to store the employee hourly rate
        int EMP_HOUR_RATE = 80;
        //variable to store the hour
        int hour = 0;
        //variable to store the employee daily wage
        int DailyWage = 0;

        //method to check the employee daily wages
        public void CheckDailyEmpWage ()
        {
            // Create an object of the UC1EmpAttendance class
            UC1EmpAttendance empAtt = new UC1EmpAttendance();
            
            //Get the result of the employee attendance
            bool result = empAtt.CheckEmpAttendance();

            //when the employee is present
            if(result)
            {
                //set the hour to 8
                hour += 8;
            }

            //calculate the daily wage by multiplaying the hour to employee hour rate
            DailyWage = hour * EMP_HOUR_RATE;

            //Display the employee daily wage
            Console.WriteLine("Employee Daily Wage is: " + DailyWage);
        }
        

    }
}
