using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPICSharpTask5.Part_2_Dynamic_Binding
{
    //Q6. Create two derived classes:
    //part 2
    //Engineer : Person with properties Field and YearsOfExperience
    public class Engineer : Person
    {
        public string Field { get; set; }
        public int YearsOfExperience { get; set; }

        //hide Greet() with new
        public new void Greet()
        {
            Console.WriteLine("I am an Engineer.");
        }

        //override Display() to include all data.
        public override void Display()
        {
            Console.WriteLine("ID: " + ID + ", Name: " + Name + ", Age: " + Age +
                               ", Field: " + Field + ", Years of Experience: " + YearsOfExperience);
        }
    }
}
