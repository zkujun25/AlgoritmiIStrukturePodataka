﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleList
{
    internal class Node
    {
        public object Element { get; private set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }

        public Node(object element, Node next, Node prev)
        {
            Element = element;
            Next = next;
            Prev = prev;
        }


    }
}
