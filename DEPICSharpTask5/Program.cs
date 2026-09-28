using DEPICSharpTask5.Part_1_Static_Binding;
using DEPICSharpTask5.Part_2_Dynamic_Binding;
using DEPICSharpTask5.Part_3_Interfaces;

namespace DEPICSharpTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. In Main method, create a Shape variable holding a Shape object, and a Cube variable holding a Cube object.
            //Call the Area() method on both variables and print the results to the console.
            Shape shape = new Shape(2, 3);
            Console.WriteLine("shape.Area() = " + shape.Area());       // print 6
 
            Cube cube = new Cube(2, 3, 4);
            Console.WriteLine("cube.Area() = " + cube.Area());         // print 24 (2*3*4)

            Shape shapeRef = new Cube(2, 3, 4);
            Console.WriteLine("shapeRef.Area() = " + shapeRef.Area()); // print 6, NOT 24!

            /*
             * Answer / Explanation
               shape.Area() → prints 6 (2 × 3). Straightforward — a Shape calling Shape.Area().
               cube.Area() → prints 24 (2 × 3 × 4). The variable's compile-time type is Cube, so Cube.Area() is called.
               shapeRef.Area() → prints 6, not 24. Even though the actual object at runtime is a Cube, the variable shapeRef is declared as type Shape. Because Area() was hidden with new (not overridden with virtual/override), the compiler decides at compile time which Area() to call, based purely on the declared type of the reference (Shape), completely ignoring the actual object type.

            * This is exactly early/static binding: the method to call is baked into the compiled code at compile time,
            * looking only at the reference's declared type — it never even checks what the object really is at runtime.
            */

            //-----------------------------------------------------------------------------

            //4. Declare object obj = new Cube(1, 2, 3); and call obj.ToString().
            object obj = new Cube(1, 2, 3);
            Console.WriteLine(obj.ToString()); // prints "(Width = 1, Height = 2)"

            //Which ToString() runs and why??

            /*
             * Answer / Explanation
               The ToString() method that runs is the one from the Shape class, not the Cube class. This is because the obj variable is declared as type object, and the ToString() method is not overridden in the Cube class. Therefore, when obj.ToString() is called, it uses the implementation of ToString() from the Shape class, which is the base class of Cube.
            */

            // What concept does this demonstrate (late/dynamic binding)??

            /*
             * Answer / Explanation
               This demonstrates late/dynamic binding. The method to call is determined at runtime based on the actual type of the object (Cube), but since Cube does not override ToString(), it falls back to the implementation in the base class (Shape). If Cube had overridden ToString(), that implementation would have been called instead.
            */

            //Why did ToString() behave polymorphically while Area() did not??

            /*
             * Answer / Explanation
               ToString() behaved polymorphically because it is a virtual method defined in the base class (object) and can be overridden in derived classes. In contrast, Area() was hidden using the new keyword in the Cube class, which means it does not participate in polymorphism. The compiler resolves the method call based on the declared type of the reference (Shape), leading to early binding for Area(), while ToString() allows for late binding due to its virtual nature.
            */

            //------------------------------------------------------------------------------

            // 7. part 2 : main

            //Create a Doctor object (using object initializer syntax) stored in a Person reference and pass it to ProcessPerson.
            Person doctor = new Doctor
            {
                ID = 1,
                Name = "Dr. Ali",
                Age = 40,
                Specialty = "Cardiology"
            };
            ProcessPersons.ProcessPerson(doctor);

            Console.WriteLine();

            // Create an Engineer object the same way and pass it too.
            Person engineer = new Engineer
            {
                ID = 2,
                Name = "Eng. Nour",
                Age = 30,
                Field = "Software",
                YearsOfExperience = 5
            };
            ProcessPersons.ProcessPerson(engineer);

            //Which method calls are resolved at compile time and which at runtime??
            /*
             * Answer / Explanation
               The method calls to ProcessPerson are resolved at compile time because the method is static and the type of the parameter is known at compile time (Person). However, the calls to Display() within ProcessPerson are resolved at runtime due to polymorphism. The actual method that gets called depends on the runtime type of the object (Doctor or Engineer), allowing for dynamic dispatch.
            */

            //Why does Greet() print the base version while Display() prints the derived version??
            /*
             * Answer / Explanation
               Greet() prints the base version because it is not marked as virtual in the Person class, so it does not participate in polymorphism. The method call is resolved at compile time based on the declared type of the reference (Person). In contrast, Display() is marked as virtual in the Person class and overridden in the derived classes (Doctor and Engineer). This allows for dynamic dispatch, where the method call is resolved at runtime based on the actual type of the object, resulting in the derived version being executed.
            */

            //------------------------------------------------------------------------------

            //8.

            //What happens if you remove virtual from Display() in Person??
            /*
             * Answer / Explanation
               If you remove the virtual keyword from Display() in the Person class, the method will no longer support polymorphism. As a result, when ProcessPerson calls Display(), it will always invoke the base version of Display() defined in Person, regardless of whether the actual object is a Doctor or an Engineer. This means that the derived versions of Display() in Doctor and Engineer will not be called, and the output will always reflect the base implementation.
            */

            // What compiler warning/error appears in the derived classes, and what does it mean??
            /*
             * Answer / Explanation
               If you remove the virtual keyword from Display() in the Person class, the compiler will generate a warning in the derived classes (Doctor and Engineer) indicating that they are hiding a non-virtual member. The warning will typically state something like "Member 'Display' hides inherited member 'Person.Display()'. Use the new keyword if hiding was intended." This means that the derived classes are defining a method with the same name as a method in the base class, but since the base method is not virtual, it does not participate in polymorphism. The new keyword can be used to explicitly indicate that the derived method is intended to hide the base method, but it will not enable polymorphic behavior.
            */

            //------------------------------------------------------------------------------

            //Q12. In Main:
            //Create each class with its concrete type and call its methods.
            Car car = new Car();
            car.MoveForward();
            car.MoveBackward();

            Ship1 ship = new Ship1();
            ship.MoveForward();
            ship.MoveBackward();

            Airplane airplane = new Airplane();
            airplane.MoveForward();
            airplane.MoveUp();

            Console.WriteLine();

            //declare IMoveable carRef = new Car(); 
            IMoveable carRef = new Car();

            //IMoveable planeRef = new Airplane(); 
            IMoveable planeRef = new Airplane();

            //call MoveForward()/MoveBackward() through the interface references.
            carRef.MoveForward();
            carRef.MoveBackward();

            planeRef.MoveForward();
            planeRef.MoveBackward();

            /*Can you call MoveUp() on planeRef? Why or why not??
             No, you cannot call MoveUp() on planeRef because planeRef is of type IMoveable,
             and the IMoveable interface does not define a MoveUp() method. You would need
             to cast planeRef to Airplane to access the MoveUp() method.
            */

            /*What reference type would you need??
             You would need a reference of type Airplane to call the MoveUp() method. For example:
             Airplane airplaneRef = new Airplane();
             airplaneRef.MoveUp();
            */

            //-----------------------------------------------------------------------------

            //14.then try calling it on a Ship object directly.
            Ship ship2 = new Ship();
            ship.MoveForward();
            /* What happens, and how must you call it instead??
             * Answer :
              you must call it through an interface reference instead
            IMoveable moveableShip = ship;
            moveableShip.MoveForward();

             * Explanation :
               When you try to call MoveForward() directly on a Ship object, it will not compile because MoveForward() is implemented explicitly for the IMoveable interface.
                To call it, you must cast the Ship object to IMoveable first. 
            For example:
               ((IMoveable)ship2).MoveForward();
            */

}
}
}


