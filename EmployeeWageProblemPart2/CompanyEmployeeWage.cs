﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblemPart2
{
    public class CompanyEmployeeWage
    {
        /// Variables
        public string company;
        public int maxWorkingHours;
        public int maxWorkingDays;
        public int empRatePerHour;
        public int totalEmployeeWage;

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyEmpWage"/> class.
        /// </summary>
        /// <param name="company">The company.</param>
        /// <param name="empRatePerHour">The emp rate per hour.</param>
        /// <param name="maxWorkingDays">The maximum working days.</param>
        /// <param name="maxWorkingHours">The maximum working hours.</param>
        public CompanyEmployeeWage(string company, int empRatePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }

        /// <summary>
        /// Sets the total employee wage.
        /// </summary>
        /// <param name="totalEmployeeWage">The total employee wage.</param>
        public void SetTotalEmployeeWage(int totalEmployeeWage)
        {
            this.totalEmployeeWage = totalEmployeeWage;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        override
        public string ToString()
        {
            return "Total Employee Wage for" + this.company + " is " + this.totalEmployeeWage;
        }
    }
}
