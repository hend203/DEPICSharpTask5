using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPICSharpTask5.Part_1_Static_Binding
{
    //2. Create a class Cube that inherits from Shape:
    public class Cube : Shape
    {
        public double Depth { get; set; }

        // Add a new property Depth initialized through the constructor (use : base(...)).
        public Cube(double width, double height, double depth) : base(width, height)
        {
            Depth = depth;
        }

        // Hide the Area() method using the new keyword so it returns base.Area() * Depth.
        public new double Area()
        {
            return base.Area() * Depth;
        }

        // Add a Print() method that prints all three dimensions.
        public void Print()
        {
            Console.WriteLine("Width = " + Width + ", Height = " + Height + ", Depth = " + Depth);
        }
    }
}
