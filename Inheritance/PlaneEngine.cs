using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class PlaneEngine : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Execute Plane Engine");
        }
    }
}
