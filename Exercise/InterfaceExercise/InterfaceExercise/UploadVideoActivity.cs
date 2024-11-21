using System;

namespace InterfaceExercise
{
    internal class UploadVideoActivity : IWorkflowActivity
    {
        public void Execute()
        {
            // Uploading video logic...
            Console.WriteLine("Video uploaded to the cloud service...");
        }
    }
}
