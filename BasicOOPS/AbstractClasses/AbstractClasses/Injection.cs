using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Injection: Vulnerability
    {
        // Handle the necessary declarations from abstract class.
        public override string Name { get; set; }
        public override int Score { get ; set ; }
        public override void Impact()
        {
            Console.WriteLine("Injection vulnerabilities can lead to RCE!");
        }

        // Constructor 1 => Only injection vulnerability name. 
        public Injection(string Name)
        {
            this.Name = Name; 
        }
        // Constructor 2 => Full Declaration. 
        public Injection (string Name, int Score)
        {
            this.Name = Name;
            this.Score = Score;
        }

        // Method of the Injection Class. 
        public void Examples()
        {
            Console.WriteLine("Examples of Injection vulnerabilities include => SQL Injection, XSS, etc.");
        }

    }
}
