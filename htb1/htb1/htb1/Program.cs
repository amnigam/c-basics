using System;
using System.IO;
using HTBLibrary; 

namespace htb1
{
    class Program
    {
        public enum DayOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
        }

        static void Main(string[] args)
        {
            DayOfWeek today = DayOfWeek.Monday;
            int tomorrowIndex = (int) DayOfWeek.Tuesday; 
            Console.WriteLine(today);
            Console.WriteLine($"Index for tomorrow is: {tomorrowIndex}");

            Console.WriteLine("Do you wish to enter a choice (yes/no) ?");
            String choice = Console.ReadLine();

            for (int i = 0; i < 100; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            for (char c = 'a'; c <= 'z'; c++)
            {
                if (c == '\u006E')
                {
                    break;
                }
                Console.Write(c);
            }
            Console.WriteLine();
            //int? choiceIndex = null; 
            //choiceIndex = (choice == "yes") ? 4 : null; 

            // Reversing a string using Reverse method defined on Array
            string message = "...semit egnartS ?thgir drieW...seludom ymedacA setirw neht dna god yzal eht revo spmuj xof nworb kciuq ehT";
            char[] charArray = message.ToCharArray();   // Convert string into a Char Array
            Array.Reverse(charArray);                   // Use Reverse static method available on Array
            Console.WriteLine(new string(charArray));   // Print out the reversed char array as a STRING.

            try
            {
                int[] arr = new int[8];
                arr[11] = 69;
            }
            catch (IndexOutOfRangeException ex)
            {
                // Handle specific exception first
                Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
            }

            // Checking if a file exists. 
            // Checking for this file => "C:\Users\Amit Nigam\ToolsSetups\owasp_zap_root_ca.cer"
            string filePath = @"C:\Users\Amit Nigam\ToolsSetups\owasp_zap_root_ca.cer";

            Func<string,bool> exists = (string path) =>
            {
                if (File.Exists(path) == false)
                    return false;
                else
                    return true;
            };

            var x = exists(filePath);
            Console.WriteLine($"Does the file exist: {x}");

            Console.WriteLine(Flag.GetFlag()); 
        }
    }
}
