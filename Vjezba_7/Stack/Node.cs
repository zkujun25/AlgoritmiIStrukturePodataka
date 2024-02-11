using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_7
{
    internal class Node
    {
        public string Name { get; set; }

        public int Value { get; set; }

        public Node Next { get; set; }

        public Node(string name, int value, Node next)
        {
            this.Name = name;
            this.Value = value;
            this.Next = next;
        }
    }
}
