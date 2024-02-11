using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DoubleList
{
    internal class BillList
    {
        Node head;
        int count;

        public int Count
        {
            get { return count; }
        }

        public BillList()
        {
            Node dummyNode = new Node(null, null, null);

            dummyNode.Next = dummyNode;
            dummyNode.Prev = dummyNode;

            head = dummyNode;

            count = 0;
        }

        private bool IsEmpty()
        {
            if (count == 0) return true;
            return false;
        }

        public void Append(object data) 
        {
            Node newNode = new Node(data, head, head.Prev);
            head.Prev.Next = newNode;
            head.Prev = newNode;
            count++;
        }

        private Node? Find(object data)
        {
            Node current = head.Next;
            while (current != head)
            {
                if (current.Element.Equals(data))
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public void Remove(object data)
        {
            Node? nodeToRemove = Find(data);
            if (nodeToRemove != null)
            {
                nodeToRemove.Prev.Next = nodeToRemove.Next;
                nodeToRemove.Next.Prev = nodeToRemove.Prev;
                count--;
            }
        }
        public bool Search(object data)
        {
            return Find(data) != null;
        }

        public void Display()
        {
            Node current = head.Next;
            while (current != head)
            {
                Console.WriteLine(current.Element);
                current = current.Next;
            }
        }
    }
}
