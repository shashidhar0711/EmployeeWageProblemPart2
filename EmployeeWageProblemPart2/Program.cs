using System;
using EmployeeWageProblemPart2;

namespace EmployeeWageProblemPart2
{
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            /// Creating reference of object array
            EmployeeWageArray employeeWageArray = new EmployeeWageArray();
            employeeWageArray.AddCompany("Microsoft", 20, 15, 120);
            employeeWageArray.AddCompany("Tesla", 30, 25, 200);
            employeeWageArray.EmployeeWageCalculation();
        }
    }
}