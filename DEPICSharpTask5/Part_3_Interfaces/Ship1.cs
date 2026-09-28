using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPICSharpTask5.Part_3_Interfaces
{
    //11. Implement the interfaces in the following classes:
    // part 2: Ship : IMoveable — prints messages about moving on the sea.
    public class Ship1 : IMoveable
    {
        public void MoveForward()
        {
            Console.WriteLine("Ship is sailing forward on the sea.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Ship is sailing backward on the sea.");
        }
    }
}
