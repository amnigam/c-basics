using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace events

{
    public class MD5GeneratedEventArgs : EventArgs
    {
        public string Hash{ get; set; }
    }

    internal class HashGen
    {
        // This class contains only one method to generate MD5 hash for the path specified. 

        // In order to raise an event, there are 3 things that need to be done. 
        // 1. Define a delegate => contract between publishing party and subscriber
        // 2. Define an event based on that delegate
        // 3. Raise the event.

        // Below is the first step. Declaring the delegate. 
        // First one is commented because, we are passing EventArgs to our subscribing services. 

        // public delegate void MD5GeneratedEventHandler(object source, EventArgs args);   // object & EventArgs are accepted norms.
        public delegate void MD5GeneratedEventHandler(object source, MD5GeneratedEventArgs args);


        // The next step is to define an event based on the delegate defined above.
        public event MD5GeneratedEventHandler MD5Generated;     // EventHandler is dropped as per naming convention. 
        public string GenerateMD5(string path)
        {
            // Initializations of components required to create the hash. 
            MD5 md5 = null;         // Instance of MD5
            FileStream stream = null;
            StringBuilder sb = new StringBuilder();

            // Try to read the file as a Stream. 
            try
            {
                stream = File.OpenRead(path);   // OpenRead returns a read only Stream. This allows to read all types of files e.g., PDF, EXE etc.
                md5 = MD5.Create();

                byte[] hashBytes = md5.ComputeHash(stream);
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));     //"x2" converts the hash to Hex format. This is what we are familiar with. 
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No File found at the path specified!. Please specify right file path.");
                Environment.Exit(1);    // If file not found, exit with an error code. 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong!. {ex.Message}");
                Environment.Exit(1);
            }
            finally
            {
                if (stream != null)
                {
                    stream.Dispose();   // Free up the resources of stream
                }

                if (md5 != null)
                {
                    md5.Dispose();      // Free up resources. 
                }
            }

            string hashVal = sb.ToString();
            // Call the method that will raise the event and let subscribers know that event has happened.
            OnMD5Generated(hashVal); 

            return hashVal;       // Return a String containing MD5 hash. 
        }

        protected virtual void OnMD5Generated(string hash)
        {
            // Check if there are any subscribers to the event. 
            if (MD5Generated != null)
            {
                // MD5Generated(this, EventArgs.Empty);
                MD5Generated(this, new MD5GeneratedEventArgs() { Hash = hash }); 
            }
        }
    }
}
