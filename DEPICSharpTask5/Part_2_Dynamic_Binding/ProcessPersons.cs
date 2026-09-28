using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPICSharpTask5.Part_2_Dynamic_Binding
{
    internal class ProcessPersons
    {
        //7. Write a method ProcessPerson(Person person) that calls person.Greet() and person.Display(). 
        //part 1 : method
        public static void ProcessPerson(Person person)
        {
            person.Greet();
            person.Display();
        }
    }
}
