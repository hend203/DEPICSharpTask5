using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPICSharpTask5.Part_3_Interfaces
{
    // 9. (Pre-interface problem) Create a class Car with methods MoveForward() and MoveBackward() that just print messages
    public class Car1
    {
        public void MoveForward()
        {
            Console.WriteLine("Car is moving forward.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Car is moving backward.");
        }
        /* Now imagine you also need MoveUp()/MoveDown(). What is the problem with forcing every vehicle class to implement all four methods? (This is what interfaces solve.)
            Answer: 
        Forcing every vehicle class to implement all four methods can lead to unnecessary complexity and code duplication. 
        Not all vehicles may have the capability to move up or down (e.g., a car cannot move up or down like an airplane or a submarine). 
        This can result in empty or unimplemented methods in classes where they don't make sense, violating the Interface Segregation Principle. 
        Interfaces allow for more flexible and modular design by enabling classes to implement only the methods that are relevant to them.
        */
    }
}
