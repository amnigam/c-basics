using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncPractice
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://dog.ceo/api/breeds/image/random";
            Request r = new Request(url); 
            string outData = await r.GetAsyncWebContent();
            Console.WriteLine(outData);
            Console.Write("Enter file name with full path: ");
            string fileName = Console.ReadLine();
            FileRead fr = new FileRead(fileName);
            fr.SimpleRead();

            Console.Write("Enter second file name with full path: ");
            string fileName2 = Console.ReadLine();
            FileRead fr2 = new FileRead(fileName2);
            fr2.StreamRead();

        }



    }
}
