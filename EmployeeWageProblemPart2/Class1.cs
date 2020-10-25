/*
 *  C# CODING STANDARDS - LINE SPACE
 *  NOTE - A SINGLE BLANK LINE SEPARATES THE TWO BLOCKS i.e. USING STATEMENTS, CLASS DECLARATION, etc
 */

/******************************************************************************
 *  Compilation:  C:\Users\Theja\source\repos\EmployeeWageProblemPart2\bin\Debug\netcoreapp3.1\EmployeeWageProblemPart.exe
 *  Execution:    EmployeeWageProblemPart.exe
 *  
 *  Purpose: Computes Employee Wages.
 *
 *  @author  Shashidhar c
 *  @version 1.0
 *  @since   18-10-2020
 *
 ******************************************************************************/

/// Including the requried assemblies in to the program
using System;

namespace EmployeeWageProblemPart
{
    class Program
    {
        const int IS_EMPLOYEE_PART_TIME = 1;
        const int IS_EMPLOYEE_FULL_TIME = 2;

        static void main(String[] args)
        {
            /// Monthly Wage for multiple compani
            /// calls the Computwage method with the following parameters.
            Console.WriteLine("Employee Wage for Samsung is : " + ComputeEmpWage("Samsung", 25, 24, 90));
            Console.WriteLine("Employee Wage for Nokia is : " + ComputeEmpWage("Nokia", 22, 22, 100));
        }
        /// <summary>
        /// Computes the emp wage.
        /// </summary>
        /// <param name="companyName">Name of the company.</param>
        /// <param name="employeeRatePerHour">The employee rate per hour.</param>
        /// <param name="numberOfWorkingDays">The number of working days.</param>
        /// <param name="maxHoursInMonth">The maximum hours in month.</param>
        /// <returns></returns>
        public static int ComputeEmpWage(String companyName, int employeeRatePerHour, int numberOfWorkingDays, int maxHoursInMonth)
        {
            int empHours = 0;
            int totalEmpHours = 0;
            int totalWorkingDays = 0;
            while (totalEmpHours < maxHoursInMonth && totalWorkingDays < numberOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                switch (random.Next(0, 3))
                {
                    case IS_EMPLOYEE_FULL_TIME:
                        empHours = 8;
                        break;
                    case IS_EMPLOYEE_PART_TIME:
                        empHours = 4;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                totalEmpHours += empHours;
            }
            return totalEmpHours * employeeRatePerHour;
        }
    }
}