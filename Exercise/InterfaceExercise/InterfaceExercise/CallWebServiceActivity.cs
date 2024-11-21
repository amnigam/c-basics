using System;

namespace InterfaceExercise
{
    internal class CallWebServiceActivity : IWorkflowActivity
    {
        public void Execute()
        {
            Console.WriteLine("Called the web service and notified that video has been uploaded...");
        }

    }
}
