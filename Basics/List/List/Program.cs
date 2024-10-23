using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A list is like an Array but it has no fixed size. Array is of fixed size. 
            List<String> food = new List<String>();     // Declaring with new(). List<Data Type> 

            // Lists have various methods available on them. Elements can be inserted by using Add.
            food.Add("Roll");
            food.Add("Chocolate");
            food.Add("Aloo Paratha");
            food.Add("Kachori");

            // Loop over LISTS with same foreach method that is used for arrays. 
            Console.WriteLine("The original LIST...");
            foreach(string item in food)
            {
                Console.WriteLine(item);
            }

            // There are some very handy methods available to LISTS. 
            food.Remove("Chocolate");       // Removes Chocolate. 
            food.Insert(2, "Samosa");       // Inserting an element at a specific location. 
            food.Sort();            // Sorts the List alphabetically. 
            food.Reverse();         // Reverses the order of the elements in the list. After sort, it becomes descending. 
            Console.WriteLine($"\nThe number of food items are: {food.Count}");
            Console.WriteLine($"Checking whether Halua is in the list... {food.Contains("Halua")}");    // Returns a Boolean. 
            Console.WriteLine($"The position of Samosa in the list is: {food.IndexOf("Samosa")+1}");    // Added 1 to index. 
            String [] foodArray = food.ToArray();       // This converts food LIST into an ARRAY. 

            // Final Loop Through of food List. 
            Console.WriteLine("\nFinal Loop through....");
            foreach(string item in food)
            {
                Console.WriteLine(item);
            }

            // Looping through foodArray. 
            Console.WriteLine("\nLooping through the Generated Food Array..."); 
            foreach(string i in foodArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
