using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public interface IWorkFlow
    {
        void Add(ITask task);
        void Remove(ITask task);
        public IEnumerable<ITask> GetTasks();
    }
}
