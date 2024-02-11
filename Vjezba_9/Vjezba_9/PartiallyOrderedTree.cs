using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shortest_Path
{
    internal class PartiallyOrderedTree : IEnumerable
    {
        internal int[] queue;
        Graph graph;
        public int last;

        public PartiallyOrderedTree(Graph graph)
        {
            this.graph = graph;
            last = graph.vertices.Length;
            queue = new int[last + 1];
            queue[0] = -1;
            for(int i = 1; i <= last; i++)
            {
                queue[i] = i - 1;
            }
        }
        public void Swap(int a, int b)
        {
            int temp = queue[a];
            queue[a] = queue[b];
            queue[b] = temp;
        }
        public double GetPriority(int a)
        {
            return graph.vertices[queue[a]].Distance;
        }
        internal void BubbleUp(int index)
        {
            while (index > 1 && GetPriority(index / 2) > GetPriority(index))
            {
                Swap(index / 2, index);
                index = index / 2;
            }
        }
        internal void BubbleDown(int index)
        {
            int smallest = index;
            int leftChild = 2 * index;
            int rightChild = 2 * index + 1;

            if (leftChild <= last && GetPriority(leftChild) < GetPriority(smallest))
            {
                smallest = leftChild;
            }

            if (rightChild <= last && GetPriority(rightChild) < GetPriority(smallest))
            {
                smallest = rightChild;
            }

            if (smallest != index)
            {
                Swap(index, smallest);
                BubbleDown(smallest);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var priority in queue)
            {
                yield return priority;
            }
        }
        public void Display()
        {
            Console.Write("Queued: ");
            for (int i = 1; i <= last; i++)
                Console.Write(queue[i] + " ");
            Console.WriteLine();
            Console.Write("Settled: ");
            for (int i = last + 1; i < queue.Length; i++)
                Console.Write(queue[i] + " ");
            Console.WriteLine();
        }

    }
}
