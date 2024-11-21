using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    internal class ConsoleOut
    {
        // public void OnMD5Generated(object source, EventArgs e)
        public void OnMD5Generated(object source, MD5GeneratedEventArgs e)
        {
            Console.WriteLine($"Printing hash on console: {e.Hash}");
        }
    }
}
