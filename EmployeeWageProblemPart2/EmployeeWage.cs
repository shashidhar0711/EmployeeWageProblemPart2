using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblemPart2
{
    class EmployeeWage
    {
        ///Constants
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;

        /// Variables
        String companyName;
        int empRatePerHour;
        int maxWorkingDays;
        int maxWorkingHours;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeWage"/> class.
        /// </summary>
        /// <param name="companyName">Name of the company.</param>
        /// <param name="empRatePerHour">The emp rate per hour.</param>
        /// <param name="maxWorkingDays">The maximum working days.</param>
        /// <param name="maxWorkingHours">The maximum working hours.</param>
        public EmployeeWage(String companyName, int empRatePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.companyName = companyName;
            this.empRatePerHour = empRatePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }

        /// <summary>
        /// Employees the wage calculation.
        /// </summary>
        public void EmployeeWageCalculation()
        {
            /// Variables
            int employeeHours = 0;
            int totalWorkingDays = 0;
            int totalWorkingHours = 0;

            /// By Looping till condition ends
            while (totalWorkingDays <= maxWorkingDays && totalWorkingHours <= maxWorkingHours)
            {

                /// Create a reference of Random class
                Random random = new Random();

                /// It gives random number 
                switch (random.Next(0, 3))
                {
                    case IS_FULL_TIME:
                        employeeHours = 8;
                        break;
                    case IS_PART_TIME:
                        employeeHours = 4;
                        break;
                    default:
                        employeeHours = 0;
                        break;
                }
                totalWorkingHours = totalWorkingHours + employeeHours;
                totalWorkingDays++;
            }
            Console.WriteLine("Employee Wage for " + companyName + " is " + empRatePerHour * totalWorkingHours);
        }
    }
}
