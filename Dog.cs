using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    // Dog.cs
    public class Dog : Animal
    {
        // Constructor
        public Dog(string name, int age) : base(name, age) { }

        // Implement the abstract method MakeSound for Dog
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says Woof!");
        }

        // Unique method for Dog
        public void FetchBall()
        {
            Console.WriteLine($"{Name} is fetching the ball!");
        }
    }

}
