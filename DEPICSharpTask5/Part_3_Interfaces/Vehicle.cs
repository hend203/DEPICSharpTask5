using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPICSharpTask5.Part_3_Interfaces
{
    //13.create a class Vehicle : IVehicle that implements all four methods as virtual.
    public class Vehicle : IVehicle
    {
        public void MoveForward()
        {
            Console.WriteLine("Vehicle is moving forward.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Vehicle is moving backward.");
        }

        public void MoveUp()
        {
            Console.WriteLine("Vehicle is moving up.");
        }

        public void MoveDown()
        {
            Console.WriteLine("Vehicle is moving down.");
        }

        /* What is the benefit of an interface inheriting other interfaces??
         * Answer:
            The benefit of an interface inheriting other interfaces is that it allows for the creation of more complex and specialized interfaces by combining the functionality of multiple interfaces.
            This promotes code reusability, modularity, and flexibility in designing software systems. 
            It enables developers to define a hierarchy of interfaces, where a derived interface can inherit the members of its base interfaces, allowing for a more organized and structured approach to defining contracts for classes to implement.
         */
    }
}
