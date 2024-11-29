using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    // Cat.cs
    public class Cat : Animal
    {
        // Constructor
        public Cat(string name, int age) : base(name, age) { }

        // Implement the abstract method MakeSound for Cat
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says Meow!");
        }

        // Unique method for Cat
        public void ScratchFurniture()
        {
            Console.WriteLine($"{Name} is scratching the furniture!");
        }
    }

}
