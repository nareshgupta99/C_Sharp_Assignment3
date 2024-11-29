using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
     static class MathHelper
    {
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("The array cannot be null or empty.");
            }

            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Length;
        }
    }
}
