using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http; 

namespace AsyncPractice
{
    internal class Request
    {
        static readonly HttpClient client = new HttpClient();
        public string Url { get; set; }
        public Request(string url) { Url = url; }

        public async Task<string> GetAsyncWebContent()
        {
            HttpResponseMessage resp = await client.GetAsync(Url);
            resp.EnsureSuccessStatusCode();
            string respBody = await resp.Content.ReadAsStringAsync();
            return respBody;
        }
    }
}
