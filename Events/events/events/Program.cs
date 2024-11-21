using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashGen hg = new HashGen();     // Publisher
            Hashout hout = new Hashout();   // Subscribing service. 
            ConsoleOut cout = new ConsoleOut();     // Second Subscribing service. 

            hg.MD5Generated += hout.OnMD5Generated;     // Subscription established.
            hg.MD5Generated += cout.OnMD5Generated;     // Establishing the second subscription. 

            Console.Write("[+] Enter the File Path: ");
            string text = Console.ReadLine();
            Console.WriteLine();
            string outText = hg.GenerateMD5(text);

            // Console.WriteLine($"MD5 Hash is: {outText}");
            Console.ReadKey();


        }
    }
}
