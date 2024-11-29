using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
     public class Program
    {
        static void Main(string[] args)
        {
            // int[] numbers = { 10, 20, 30, 40, 50 };
            //double average = MathHelper.CalculateAverage(numbers);
            //Console.WriteLine(average);

            Person person = new Person
            {
                FirstName = "John",
                LastName = "Doe"
            };

            person.PrintFullName();
            Console.ReadLine();

        }
    }
}
