using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    internal class Workflow
    {
        public IList<IWorkflowActivity> WorkflowActivities { get; set; }

        public Workflow()
        {
            WorkflowActivities = new List<IWorkflowActivity>();
        }

        public void AddWorkFlowActivity(IWorkflowActivity activity)
        {
            WorkflowActivities.Add(activity);
        }
    }
}
