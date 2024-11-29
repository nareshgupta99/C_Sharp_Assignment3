using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    // Animal.cs
    public abstract class Animal
    {
        // Properties for Name and Age
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Abstract method to make a sound, to be implemented by derived classes
        public abstract void MakeSound();

        // A method to display animal details
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

}
