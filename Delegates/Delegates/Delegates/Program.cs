using System;

namespace Delegates
{
    public delegate void LogDelegate(string message);   // Declaring our Delegate with same signature as Logging methods in Logger class.
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger lg = new Logger();       // Create a Logger object. 

            // setup our new delegte. notice how we just provide the method name. 
            LogDelegate ld = lg.LogToConsole;   // Assigning our delegate object to the method that logs to console.

            ld("Delgate is logging to console!");   // Call the delegate. Since delegate holds reference to the method, the method gets invoked.

            // Now we take our Delegate and make it multicast. That is we add another method to it. 
            ld += lg.LogToFile;     // We have now added another method to our delegate.

            // Now, when we call the delegate, it will write to console as well as the log file! 
            ld("Well, I love to write to both console & file!"); 

            // Next, we remove the method by simply using -= 
            ld -= lg.LogToConsole;      // We are saying to log only to file now. 

            ld("Well, file is the way for me to log stuff!."); 

        }
    }
}
