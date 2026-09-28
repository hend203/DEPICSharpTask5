using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPICSharpTask5.Part_3_Interfaces
{
    //14. (Challenge) Can a class implement IMoveable explicitly? Rewrite Ship.MoveForward() using explicit interface implementation (void IMoveable.MoveForward()),
    public class Ship : IMoveable
    {
        void IMoveable.MoveForward()
        {
            Console.WriteLine("Ship is sailing forward on the sea (explicit implementation).");
        }
        public void MoveBackward()
        {
            Console.WriteLine("Ship is sailing backward on the sea.");
        }
    }
    
}
