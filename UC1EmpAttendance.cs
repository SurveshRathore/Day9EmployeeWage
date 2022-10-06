using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4PPEmpWageComputation
{
    //UC1EmpAttendance class
    internal class UC1EmpAttendance
    {
        //method to check the employee attendance
        public Boolean CheckEmpAttendance ()
        {
            //set 1 for the full time employee
            int IS_FULL_TIME = 1;

            //Create an object of the Random() class
            Random random = new Random();

            //call the Next() function of the random class with the value 0 and 2
            int empAtt = random.Next(0, 2);

            //when the employee is present 
            if (empAtt == IS_FULL_TIME)
            {
                //Display employee is present
                Console.WriteLine("Employee is Present");
                return true;
            }

            //when the employee is absent 
            else
            {
                //Display employee is absent
                Console.WriteLine("Employee is Absent");
                return false;
            }
        }
        
    }
}
