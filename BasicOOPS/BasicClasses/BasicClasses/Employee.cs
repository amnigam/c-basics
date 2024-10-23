using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClasses
{
    internal class Employee
    {
        // Fields of the class. Fields are internal to class. 
        private string name;
        private int eid; 

        // Properties associated with fields. They have Getters & Setters defined. 
        public string Name
        {
            get { return name; }        // Getter for name field
            set { name = value; }       // Setter for name field
        }

        // Property for EID.
        public int Eid
        {
            get { return eid; }
            set { eid = value; }
        }

        // Constructor for the class
        public Employee (string name, int eid)
        {
            this.name = name;
            this.eid = eid;
        }

        // Method for the Class.
        public virtual void EmpWork()       // With virtual, the EmpWork method can be overriden in derived classes.
        {
            Console.WriteLine("The employee performs work.");
        }
    }
}
