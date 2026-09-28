using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPICSharpTask5.Part_1_Static_Binding
{
    //1.Create a class Shape with two auto-properties Width and Height (of type double),
     
    public class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Shape(double width, double height)
        {
            Width = width;
            Height = height;
        }
        // a constructor that initializes them, and a method Area() that returns Width * Height.
        public double Area()
        {
            return Width * Height;
        }

        // Override ToString() to return "(Width = ..., Height = ...)".
        public override string ToString()
        {
            return "(Width = " + Width + ", Height = " + Height + ")";
        }
    }
}
