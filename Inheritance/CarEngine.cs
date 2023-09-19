using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class CarEngine : ITask
    {
        public void Execute() 
        {
            Console.WriteLine("Execute Car Engine");
        }
    }
}
