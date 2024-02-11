using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SingleList
{

    public class List
    {
        private Node head;
        private Node tail;
        public List() { head = tail = null; }
        public bool IsEmpty() { return head == null; }

        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Element + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void InsertFront(object data)
        {
            if (IsEmpty())
                head = tail = new Node(data, null); //novi cvor sa elementom data, iduci pokazuje na null, head i tail triba postavit na to
            else
                head = new Node(data, head);

        }

        public void InsertEnd(object data)
        {
            if (IsEmpty())
                head = tail = new Node(data, null);
            else
            {
                tail.Next = new Node(data, null);
                tail = tail.Next;
                // tail=tail.Next=new Node(data,null);
            }
        }

        public object RemoveFront()
        {
            object element = null;
            if (IsEmpty())
                throw new Exception("List is empty!");
            element = head.Element;

            if (head.Equals(tail))
                head = tail = null;
            else
                head = head.Next;

            return element; //ovo nam triba kasnije za ispisat element koji smo pushali ili popali kod stacka
        }

        public object RemoveEnd()
        {
            object element = null;
            if (IsEmpty())
                throw new Exception("List is empty!");
            element = tail.Element;

            if (head.Equals(tail))
                head = tail = null;
            else
            {
                Node current = head;

                while (true)
                {
                    if (current.Next == tail)
                    {
                        tail = current;
                        tail.Next = null;
                        break;
                    }
                    current = current.Next;
                }
            }

            return element;
        }
    }
}
