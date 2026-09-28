using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPICSharpTask5.Part_2_Dynamic_Binding
{
    //Q6. Create two derived classes:
   //part 1
   // Doctor : Person with property Specialty  

    public class Doctor : Person
    {
        public string Specialty { get; set; }

        // hide Greet() with new
        public new void Greet()
        {
            Console.WriteLine("I am a Doctor.");
        }
        //override Display() to include the specialty.
        public override void Display()
        {
            Console.WriteLine("ID: " + ID + ", Name: " + Name + ", Age: " + Age + ", Specialty: " + Specialty);
        }
    }
}
