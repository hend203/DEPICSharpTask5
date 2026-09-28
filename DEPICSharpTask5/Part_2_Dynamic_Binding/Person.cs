using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPICSharpTask5.Part_2_Dynamic_Binding
{
    //5.5. Create a base class Person with properties ID, Name, Age, and two methods
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //Greet() (non-virtual) that prints "I am a Person."
        public void Greet()
        {
            Console.WriteLine("I am a Person.");
        }
        //Display() marked virtual that prints the person's basic data.
        public virtual void Display()
        {
            Console.WriteLine("ID: " + ID + ", Name: " + Name + ", Age: " + Age);
        }
    }
}
