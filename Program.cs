// See https://aka.ms/new-console-template for more information

using Day4PPEmpWageComputation;

// Displaying Welcome to Employee wage Computation Program
Console.WriteLine("Welcome to Employee Wage Computation Program");

//creating an object of the uc2 class
UC2EmpDailyWage empWage = new UC2EmpDailyWage();
empWage.CheckDailyEmpWage();

//creating an object of the uc3 class
UC3PartTimeEmpWage uc3pte = new UC3PartTimeEmpWage();
uc3pte.CalcPartTimeEmpWage();

//creating an object of the uc4 class
UC4SwitchCase uc4sc = new UC4SwitchCase();
uc4sc.empWageUsingSwitch();

//creating an object of the uc5 class
UC5EmpMonthWage uc5mw = new UC5EmpMonthWage();  
uc5mw.calcMonthWage();

//creating an object of the uc6 class
UC6CalcWageHourDay uc6mwhd = new UC6CalcWageHourDay();
uc6mwhd.CalcWageForWorkingHourDay();
