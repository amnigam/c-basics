using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace request
{
    internal class Program
    {   
        static readonly HttpClient client = new HttpClient(); 

        static async Task Main()
        {
            string responseBody = await GetData("http://example.com");
            System.Console.WriteLine(responseBody);
            Task<string> msg = Task.Run(async () =>
           {
               await Task.Delay(2000);
               return "Slept!";
           });

            System.Console.WriteLine(msg);
        }

        static async Task<string> GetData(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string respBody = await response.Content.ReadAsStringAsync();
            return respBody;
        }
    }
}
