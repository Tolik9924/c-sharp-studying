using System;
using System.Collections;
using System.Collections.Generic;

namespace Inheritance
{
    public class MyStack
    {        
        private readonly ArrayList _stackList = new ArrayList();

        public void Push(object item)
        {                          
            if (item == null)
                throw new InvalidOperationException("Type date should not be null");

            _stackList.Add(item);            
        }

        public object Pop()
        {
            object RemovedElement;            

            if (_stackList.Count == 0) 
            {
                throw new InvalidOperationException("List is empty.");
            }

            RemovedElement = _stackList[_stackList.Count - 1];
            _stackList.RemoveAt(_stackList.Count - 1);            
            return RemovedElement;
        }

        public void Clear()
        {
            if (_stackList.Count == 0)
                throw new InvalidOperationException("List is empty.");


           _stackList.Clear();
        }

        public int ShowCountOfList()
        {
            return _stackList.Count;
        }

        public void ShowStackList()
        {
            for(int i = 0; i < _stackList.Count; i++)
            {
                Console.WriteLine(_stackList[i]);
            }
        }
    }
}
