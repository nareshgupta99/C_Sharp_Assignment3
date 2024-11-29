using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    // Circle.cs
    public class Circle : Shape
    {
        public double Radius { get; set; }

        // Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Implement CalculateArea for Circle
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

}
