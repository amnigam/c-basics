using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Scrip:IDerivateAsset, IEquityAsset
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int StrikePrice { get; set; }

        // Constructor 1 => For equities
        public Scrip(string Name, int Price)
        {
            this.Name = Name;
            this.Price = Price;
        }

        // Constructor 2 => For Derivatives. 
        public Scrip(string Name, int Price, int StrikePrice)
        {
            this.Name=Name;
            this.Price = Price;
            this.StrikePrice = StrikePrice;
        }

        public void Action()
        {
            if (StrikePrice != 0)
            {
                Console.WriteLine("I am a Derivative!");
            } else
            {
                Console.WriteLine("I am an Equity Asset");
            }
        }

        public string LongOrShort()
        {
            Console.WriteLine("I am Long!");
            return "Long";
        }

        public void HoldOrSold()
        {
            Console.WriteLine("I am still being held!");
        }
    }
}
