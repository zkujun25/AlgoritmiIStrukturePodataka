using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vjezba4;

namespace Queue
{
    internal class Queue
    {
        List list;
        public Queue() 
        {
            list = new List();
        }
        public void Enqueue(object element)
        {
            list.InsertEnd(element);
        }

        public object Dequeue()
        {
            if (IsEmpty())
                throw new Exception("Queue is empty");
            return list.RemoveFront();
        }

        public bool IsEmpty() { return list.IsEmpty(); }
        public void Display() { list.Display(); }
    }
}
