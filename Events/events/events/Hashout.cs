using System;
using System.IO;

namespace events
{
    internal class Hashout
    {
        // public void OnMD5Generated(object source, EventArgs e)
        public void OnMD5Generated(object source, MD5GeneratedEventArgs e)
        {
            Console.WriteLine("Writing the hash to output file...");
        }
    }
}
