using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPICSharpTask5.Part_3_Interfaces
{
    //10. Create two interfaces:
    // part 1: IMoveable → MoveForward(), MoveBackward()
    public interface IMoveable
    {
        void MoveForward();
        void MoveBackward();
    }
    // part 2: IFlyable → MoveUp(), MoveDown()
    public interface IFlyable
    {
        void MoveUp();
        void MoveDown();
    }

    //13. Create an interface IVehicle that inherits from both IMoveable and IFlyable without adding new members
    public interface IVehicle : IMoveable, IFlyable
    {
    }
}
