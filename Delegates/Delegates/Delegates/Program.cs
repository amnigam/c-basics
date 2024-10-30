using System;
using System.Collections.Generic; 

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

            // Here we look at the Func Delegate referenced in our Discount class.

            // We first define a Discount strategy.
            Func<decimal, decimal> standardDiscount = total => total * 0.9m;
            Func<decimal, decimal> premiumDiscount = total => total * 0.8m;
            Func<decimal, decimal> bulkDiscount = total => total > 1000 ? total * 0.7m : total * 0.9m;

            // Create a List of totals to apply discounts to.
            List<decimal> orderTotals = new List<decimal> { 400, 1200, 2000, 700, 9000, 900, 50 }; 

            // Create an object of Discount type - this gives the applyDiscount method to the object.
            Discount ds = new Discount();

            ds.ApplyDiscounts(orderTotals, standardDiscount); 
            ds.ApplyDiscounts(orderTotals, premiumDiscount);
            ds.ApplyDiscounts(orderTotals, bulkDiscount);
        }
    }
}
