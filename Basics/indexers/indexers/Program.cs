using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This program was written to understand Indexers. In a nutshell, indexers allow classes that are semantically like collections to be handled
            // in ways similar to an array. Indexers are a form of property for a class. 

            var e = new EmailDNS("bmw");
            e["spf"] = "SPF is there";
            e["dkim"] = "DKIM is there";
            e["dmarc"] = "DMARC is there";
            Console.WriteLine($"Rating for {e.Name} is: {e.Rating}");

            var a = new EmailDNS("ey");
            a["spf"] = "Present";
            Console.WriteLine($"Rating for {a.Name} is: {a.Rating}");

            var b = new EmailDNS("jamawealth");
            b["spf"] = "Present";
            b["dkim"] = "Present";
            Console.WriteLine($"Rating for {b.Name} is: {b.Rating}");

            var c = new EmailDNS("qalara");
            c["Chuttandi"] = "Muttandi";
            Console.WriteLine($"Rating for {c.Name} is: {c.Rating}");
        }
    }
}
