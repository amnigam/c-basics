using System;

namespace InterfaceExercise
{
    internal class NotifyUserActivity : IWorkflowActivity
    {
        public void Execute()
        {
            // Notify the user that video has been uploaded. 
            Console.WriteLine("Notification sent to user...");
        }
    }
}
