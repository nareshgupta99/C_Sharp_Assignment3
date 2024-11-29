using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    // Rectangle.cs
    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        // Constructor
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Implement CalculateArea for Rectangle
        public override double CalculateArea()
        {
            return Length * Width;
        }
    }

}
