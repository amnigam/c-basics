using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays and their methods
            int[] values = { 1, 2, 3,4,5,6,100,7,3,2,1,200,3,1,5,150 };
            string[] cities = { "Delhi", "Hyderabad", "Lucknow", "Indore" };
            Console.Write("Enter the size of the design: ");
            int n = int.Parse(Console.ReadLine());  
            int[] sumVal = new int[n];  // Using a user supplied value. 

            // Standard For loop to display design
            for (int i=1; i<=n; i++ )
            {
                Console.WriteLine(String.Concat(Enumerable.Repeat("*", i))); 
            }

            // Enter the array. 
            Console.WriteLine("Enter the Array Value...");
            for (int i=0; i<n; i++)
            {
                try
                {
                    sumVal[i] = int.Parse(Console.ReadLine());
                }
                
                catch
                {
                    Console.WriteLine("Error accepting user input for arrays.");
                    break; 
                }
            }

            // Show the methods available. 
            Console.WriteLine("[+] Original Cities Array.");
            foreach (string city in cities)
            {
                Console.WriteLine(city); 
            }

            Array.Sort(cities);     // Sort the array.
            Console.WriteLine("\n");
            Console.WriteLine("[+] Cities array after sorting...");
            foreach (var city in cities) { Console.WriteLine(city); }

            // Show the max value in numeric arrays. 
            Console.WriteLine("\n");
            Console.WriteLine($"Maximum value of the Values array is: {values.Max()}");
            Console.WriteLine($"Average value in Values array is: {values.Average()}"); 
            Console.WriteLine($"Minimum value in input array is: {sumVal.Min()}");


            // Multi Dimensional (2 dimensional matrix)
            Console.WriteLine(String.Concat(Enumerable.Repeat("-",100)));
            var a = new Multi(2, 3);
            Console.WriteLine("[+] Matrix without loading of data is...");
            a.showMatrix();
            a.loadData();
            a.showMatrix();
            Console.Write("[+] Enter the row that you want to sum up: ");
            int row = int.Parse(Console.ReadLine());
            int rs = a.rowSum(row);
            Console.WriteLine($"[+] The sum of row {row} is {rs}");

        }
    }
}
