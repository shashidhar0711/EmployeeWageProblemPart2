using System;

namespace EmployeeWageProblemPart2
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            EmployeeWage Amazon = new EmployeeWage("Amazon", 20, 24, 100);
            Amazon.EmployeeWageCalculation();

            EmployeeWage Microsoft = new EmployeeWage("Microsoft", 25, 20, 150);
            Microsoft.EmployeeWageCalculation();
        }
    }
}