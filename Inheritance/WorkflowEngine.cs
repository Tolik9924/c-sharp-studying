using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class WorkflowEngine
    {       
        public void Run(IWorkFlow workFlow) 
        {
            foreach (ITask I in workFlow.GetTasks())
            {
                try
                {
                    I.Execute();
                }
                catch (Exception)
                {
                    throw;
                }               
            }
        }
    }
}
