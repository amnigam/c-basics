using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static readonly HttpClient client = new HttpClient();
        async Task CertificateData(string cn)
        {
            try
            {
                using HttpResponseMessage resp = await client.GetAsync("https://crts.sh/?cn=cn&output=json"); 
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Testing some basic classes!");
            Employee a = new Employee();
            a.name = "John Chutiya";
            a.eid = 9922;
            a.greet();
            Console.ReadKey(); 
        }
    }
}
