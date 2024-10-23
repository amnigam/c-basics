using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        enum PriceType
        {
            Low,
            Medium,
            Costly
        }

        static void Main(string[] args)
        {
            // This program explores Abstract classes, Interfaces & Enums. 
            var inj = new Injection("SQLI");
            inj.Score = 9;
            Console.WriteLine($"The vulnerability name is {inj.Name} and the score is {inj.Score}");
            inj.Impact();       // Implemented as part of Abstract class's guidelines.
            inj.Shout();        // Regular method as part of Vulnerability base class. 
            inj.Examples();     // Method available only to Injection class objects. 

            // A new Example, illustrating the second constructor usage; with 2 arguments. 
            var inj2 = new Injection("XSS", 4);
            Console.WriteLine($"\nAnother vulnerability name is {inj2.Name} and the score is {inj2.Score}");
            inj2.Impact();
            inj2.Shout();
            inj2.Examples();

            // Interface Examples. Derivatives.
            Scrip hdfc = new Scrip("HDFCBANK", 1445, 1500);
            Console.WriteLine($"\nName is: {hdfc.Name}");
            Console.WriteLine($"Price is: {hdfc.Price}");
            Console.WriteLine($"Strike Price is: {hdfc.StrikePrice}");
            hdfc.Action();
            hdfc.LongOrShort();
            hdfc.HoldOrSold();

            // Interface Examples. Equity. 
            // Interface Examples. 
            Scrip dbol = new Scrip("Dhampur Bio Organics Limited", 125);
            Console.WriteLine($"\nName is: {dbol.Name}");
            Console.WriteLine($"Price is: {dbol.Price}");
            Console.WriteLine($"Strike Price is: {dbol.StrikePrice}");
            dbol.Action();
            dbol.LongOrShort();
            dbol.HoldOrSold();

            // Enum Demo. 
            Scrip polyplex = new Scrip("Polyplex", 850);
            
            // Create a new list of type Scrip and add all created scrips in it.
            List<Scrip> investment = new List<Scrip>(); 
            investment.Add(hdfc);
            investment.Add(dbol);   
            investment.Add(polyplex);

            Console.WriteLine("\n");

            foreach (Scrip x in investment)
            {
                if (x.Price <=500) {
                    PriceType p = PriceType.Low;
                    Console.WriteLine($"{x.Name} is at a {p} price point.");
                } else if (x.Price >500 && x.Price < 1000) {
                    PriceType p = PriceType.Medium;
                    Console.WriteLine($"{x.Name} is at a {p} price point."); 
                } else
                {
                    PriceType p = PriceType.Costly;
                    Console.WriteLine($"{x.Name} is priced {p}.");
                }
            }


        }
    }
}
