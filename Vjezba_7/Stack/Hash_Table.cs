using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vjezba_7
{
    internal class Hash_Table
    {
        private Node[] buckets;
        private int length;
        public Hash_Table(int length)
        {
            this.length = length;
            buckets = new Node[length];
        }
        public void Display()
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(i + ": ");
                Node current = buckets[i];

                while (current != null)
                {
                    Console.Write($"[{current.Name}, {current.Value}] ");
                    current = current.Next;
                }
                Console.WriteLine();

            }
        }

        private int Hash(string key)
        {
            int hash = 0;

            foreach (char c in key)
            {
                hash += (int)c;
            }

            return hash % length;
        }

        public void Insert(string name, int value)
        {
            int index = Hash(name);
            Node newNode = new Node(name, value, null);

            if (buckets[index] == null)
            {
                buckets[index] = newNode;
            }
            else
            {
                // Add the new node at the beginning of the linked list
                newNode.Next = buckets[index];
                buckets[index] = newNode;
            }
        }

        public int Search(string name)
        {
            int index = Hash(name);
            Node current = buckets[index];

            while (current != null)
            {
                if (current.Name == name)
                {
                    // Node with the given name found, return its value
                    return current.Value;
                }

                current = current.Next;
            }

            throw new KeyNotFoundException($"Key '{name}' not found in the hash table.");
        }

        public void Delete(string name)
        {
            int index = Hash(name);

            if (buckets[index] == null)
            {
                throw new KeyNotFoundException($"Key '{name}' not found in the hash table.");
            }

            if (buckets[index].Name == name)
            {
                buckets[index] = buckets[index].Next;
                return;
            }

            Node current = buckets[index];
            while (current.Next != null && current.Next.Name != name)
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                throw new KeyNotFoundException($"Key '{name}' not found in the hash table.");
            }

            current.Next = current.Next.Next;
        }
    }
}
