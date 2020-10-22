using System;

namespace EmployeeWageProblemPart2
{
    class Program
    {
        const int IS_EMPLOYEE_FULL_TIME = 1;
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            /// Computation
            Console.WriteLine(EmployeeCheck());
        }
        public static String EmployeeCheck()
        {
            /// Create References For Random Class
            Random random = new Random();

            /// It Will Give Random Value
            int employeeCheck = random.Next(0, 2);

            /// Checks If Employee is Present, It will return Present Message
            /// If Employee is Not Present, It will return Absent Message
            if (employeeCheck == IS_EMPLOYEE_FULL_TIME)
            {
                return "Employee is Present";
            }
            
            return "Employee is Absent"; 
        }
    }
}