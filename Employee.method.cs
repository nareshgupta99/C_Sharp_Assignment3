using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public partial class Employee
    {
        public double CalculateSalary()
        {
            return BaseSalary + Bonus - Deduction;
        }

        // Method to calculate the annual salary
        public double CalculateAnnualSalary()
        {
            return CalculateSalary() * 12;
        }

        // Method to calculate salary based on performance
        public double CalculatePerformanceBasedSalary(double performanceFactor)
        {
            return CalculateSalary() * performanceFactor;
        }
    }
}
