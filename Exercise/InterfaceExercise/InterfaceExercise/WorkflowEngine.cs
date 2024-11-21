using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    internal class WorkflowEngine
    {
        public Workflow Workflow { get;  }
        public WorkflowEngine (Workflow wf)
        {
            Workflow = wf;
        }

        public void Run()
        {
            foreach (var act in Workflow.WorkflowActivities)
            {
                act.Execute();
            }
        }

    }

}
