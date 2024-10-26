// See https://aka.ms/new-console-template for more information
using Assessment; 
using System;
using System.Net.Http;
using System.Threading.Tasks; 

namespace dirbrute; 
class Program {
    static readonly HttpClient client = new HttpClient(); 
    static async Task Main(string[] args) {
        var x = new Words();        // Create an instance of Words class to access the method that shows all words. next step.
        var wordCollection = x.GetWordList();   // This is a Hash Set. GetWordList gets us the hash set. 

        string ipAddr = "10.129.205.211";   // IP address of the spawned web server. 
        string url = $"http://{ipAddr}/";   

        foreach (var word in wordCollection) {
            try {
                System.Console.WriteLine($"Request to URL => {url+word+"/"+"flag.txt"}");   // Adding flag.txt to every path from wordCollection (sensitive file)
                HttpResponseMessage resp = await client.GetAsync(url+word+"/"+"flag.txt"); 
                resp.EnsureSuccessStatusCode();
                string respBody = await resp.Content.ReadAsStringAsync();
                System.Console.WriteLine(respBody);
            } 
        catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound) {
            // Do nothing for not found. This doesn't clutter our console output with 404 errors. 
        }
        catch (HttpRequestException e) {
                System.Console.WriteLine($"Errored! {e.Message}");  // Only in case there is a genuine error (not 404); show it on screen.
            }
        }
    }
}