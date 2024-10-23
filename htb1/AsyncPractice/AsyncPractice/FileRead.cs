using System;
using System.IO;

namespace AsyncPractice
{
    // This class handles reading files. It does so in 2 different ways. 
    internal class FileRead
    {
        private string FileName { get; set; }       // Property capturing full file name along with path.

        public FileRead(string name)       // Constructor only requires the file name and path.
        {
            FileName = name;
        }

        // Method 1 - Leverages simple read which utilizes the ReadAllLines method. This gives an array of lines (string). 
        public void SimpleRead()
        {
            string[] lines = File.ReadAllLines(FileName);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        // Method 2 - Leverages the FileStream and StreamReader. 
        public void StreamRead()
        {
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                {
                    sr = new StreamReader(fs);
                    string line = sr.ReadLine(); 
                    while (line != null)
                    {
                        Console.WriteLine(line); 
                        line = sr.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong while reading the file!. {ex.Message}"); 
            }
            finally
            {
                fs.Close();
                sr.Close(); 
            }
        }
    }
}
