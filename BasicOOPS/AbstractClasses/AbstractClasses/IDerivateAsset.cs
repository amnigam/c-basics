using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal interface IDerivateAsset
    {
        string Name { get; }
        int Price { get; }
        int StrikePrice { get; }

        string LongOrShort();   // Interface tells classes to implement LongOrShort method natively. 
      
    }
}
