using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPICSharpTask5.Part_3_Interfaces
{
    //11. Implement the interfaces in the following classes:
    // part 3: Airplane : IMoveable, IFlyable — prints messages about moving in the air.
    public class Airplane : IMoveable, IFlyable
    {
        public void MoveForward()
        {
            Console.WriteLine("Airplane is flying forward in the air.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Airplane is flying backward in the air.");
        }

        public void MoveUp()
        {
            Console.WriteLine("Airplane is ascending.");
        }

        public void MoveDown()
        {
            Console.WriteLine("Airplane is descending.");
        }
    }
}
