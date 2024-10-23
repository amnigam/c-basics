using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal interface IEquityAsset
    {
        string Name { get; }
        int Price { get; }
        
        // Method that an interface should implement. 
        void Action();

    }
}
