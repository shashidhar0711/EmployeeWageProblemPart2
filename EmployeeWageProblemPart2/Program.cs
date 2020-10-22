using System;

namespace EmployeeWageProblemPart2
{
    class Program
    {
        const int IS_EMPLOYEE_FULL_TIME = 1;
        const int IS_EMPLOYEE_PART_TIME = 2;
        const int EMPLOYEE_RATE_PER_HOUR = 20;
        const int NUM_0F_WORKING_DAYS = 20;
        const int MAX_HOURS_IN_MONTH =100;

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            /// Computation
            Console.WriteLine("Total Employee Wages :: " + EmployeeCheck());
        }
        public static int EmployeeCheck()
        {
            /// variable
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWokingDays = 0;

            /// By Looping Untill Maximum Condition Reached
            while (totalEmpHrs <= MAX_HOURS_IN_MONTH && totalWokingDays <= NUM_0F_WORKING_DAYS)
            {
                /// Create References For Random Class
                Random random = new Random();

                /// By Using Switch Case
                /// Checks If Employee is Full Time, It will give Full time Working hours
                /// If Employee is Part Time, It will give Part time Working hours
                switch (random.Next(0, 3))
                {
                    case IS_EMPLOYEE_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_EMPLOYEE_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs = totalEmpHrs + empHrs;
                totalWokingDays++;
            }
            /// It will returns a Total Employee Wage
            return totalEmpHrs * EMPLOYEE_RATE_PER_HOUR;
        }
    }
}