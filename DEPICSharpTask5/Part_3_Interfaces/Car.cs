using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPICSharpTask5.Part_3_Interfaces
{
    //11. Implement the interfaces in three classes:
    // part 1: Car : IMoveable — prints messages about moving on the ground.
    public class Car : IMoveable
    {
        public void MoveForward()
        {
            Console.WriteLine("Car is driving forward on the ground.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Car is reversing on the ground.");
        }
    }
}
