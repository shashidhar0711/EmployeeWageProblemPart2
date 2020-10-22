using System;

namespace EmployeeWageProblemPart2
{
    class Program
    {
        const int IS_EMPLOYEE_FULL_TIME = 1;
        const int IS_EMPLOYEE_PART_TIME = 2;
        const int EMPLOYEE_RATE_PER_HOUR = 20;

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            /// Computation
            Console.WriteLine("Employee Daily Wage is :: " + EmployeeCheck());
        }
        public static int EmployeeCheck()
        {
            /// variable
            int empHrs = 0;

            /// Create References For Random Class
            Random random = new Random();
            /// It Will Give Random Value
            int employeeCheck = random.Next(0, 3);

            /// By Using Switch Case
            /// Checks If Employee is Full Time, It will give Full time Working hours
            /// If Employee is Part Time, It will give Part time Working hours
            switch(employeeCheck)
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

            /// It will returns a Daily Wage
            return empHrs * EMPLOYEE_RATE_PER_HOUR;
        }
    }
}