using Vjezba4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Stack
    {
        List list;

        public bool IsEmpty() { return list.IsEmpty(); }
        public void Display() { list.Display(); }

        public Stack() 
        {
            list = new List();
        }

        public void Push(object element)
        {
            list.InsertFront(element);
        }

        public object Pop()
        {
            if (IsEmpty())
                throw new Exception("Stack is empty");
            return list.RemoveFront();
        }
    }
}
