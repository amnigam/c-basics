using System;
using System.IO;

namespace Delegates
{
    internal class Logger
    {
        // Method to log to console. 
        public void LogToConsole (string msg)
        {
            Console.WriteLine($"Console Log: { msg}");
        }

        // Method to write to a logging file on Desktop. 
        public void LogToFile (string msg)
        {
            string textToWrite = msg + Environment.NewLine; // Append a new line at the end of the line. 
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);  // Desktop is one location. You can use ProgramFiles etc.

            // AppendAllText creates a file if it doesn't exist and appends on to it. 
            File.AppendAllText (Path.Combine(docPath, "LogFile.txt"), textToWrite);
        }
    }
}
