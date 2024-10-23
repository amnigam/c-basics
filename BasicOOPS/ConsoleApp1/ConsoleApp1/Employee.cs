using System;

namespace ConsoleApp1
{
    internal class Employee
    {
        public string name;
        public int eid; 

        public void greet()
        {
            Console.WriteLine($"The name is: {this.name}"); 
        }
    }
}
