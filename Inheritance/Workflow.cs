using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Workflow : IWorkFlow
    {
        private readonly List<ITask> _executeList = new List<ITask>();                
        public void Add(ITask task)
        {
            _executeList.Add(task);
        }

        public void Remove(ITask task)
        {
            _executeList.Remove(task);
        }

        public IEnumerable<ITask> GetTasks() 
        { 
            return _executeList;
        }
    }
}
