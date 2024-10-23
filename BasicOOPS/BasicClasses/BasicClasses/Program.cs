using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a new Employee Tom.
            Employee tom = new Employee("Tom", 12345);

            // Retrieving Tom's Properties. 
            Console.WriteLine($"Name of the Employee is: {tom.Name}");
            Console.WriteLine($"Employee ID: {tom.Eid}");

            // Retrieving the Behavior or Method
            tom.EmpWork();

            // Changing name of tom object to Chutiya.Showcasing the Setter Function in the Property.
            tom.Name = "chutiya";
            Console.WriteLine($"The new name of the Employee is: {tom.Name}");

            // Inheritance. John the Developer. 
            var john = new Developers("John", 11111);
            Console.WriteLine($"\nHere is my name: {john.Name}");
            Console.WriteLine($"Here is my Employee ID: {john.Eid}");
            Console.WriteLine("Here is the Method from base class still available to derived class...");
            john.EmpWork();     // Base Class Method available to derived classes. But with Changed behavior. Polymorphism.
            Console.WriteLine("Here is the Derived class method.....\n");
            john.skillCall();
        }
    }
}
