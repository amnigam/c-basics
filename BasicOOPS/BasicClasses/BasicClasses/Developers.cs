using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClasses
{
    internal class Developers:Employee
    {
        public Developers(string name, int eid) : base(name, eid)
        {
        }

        // Method that is intrinsic to this class. 
        public void skillCall()
        {
            Console.WriteLine("I am a developer and my skill is Programming.");
        }

        // Calling the method of Base class but making it perform something else. Polymorphism. 
        public override void EmpWork()
        {
            Console.WriteLine("Polymorphism at work bro! Same method different output!");
        }
    }
}
