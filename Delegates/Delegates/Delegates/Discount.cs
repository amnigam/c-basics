using System;
using System.Collections.Generic;

namespace Delegates
{
    internal class Discount
    {
        // This class defines a method that can be used to apply discounts to a List of totals.
        // It takes a list of totals and a Function Delegate that has an input of decimal and output of decimal. 
        public void ApplyDiscounts (List<decimal> orderTotals, Func<decimal, decimal>discountStrategy)
        {
            Console.WriteLine("[+] Discounted Totals");
            Console.WriteLine("-------------------------------");

            foreach (var total in orderTotals)
            {
                decimal discountedTotal = discountStrategy(total);  // Discounted value for the element in Total's List is computed by passing it to func delegate
                Console.WriteLine($"Original Price: {total},    Discounted Price: {discountedTotal}");
            }
            Console.WriteLine();
        }
    }
}
