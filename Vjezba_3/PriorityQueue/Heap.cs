using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    internal class Heap
    {
        int size;
        int last;
        int[] priorities;

        public Heap(int size)
        {
            this.size = size;
            priorities = new int[size + 1];
            last = 0;
        }

        public void Insert(int priority)
        {
            if (last >= size)
            {
                throw new InvalidOperationException("Queue is full");
            }

            last++;
            priorities[last] = priority;
            BubbleUp(last);
        }

        public int Retrieve()
        {
            if (last == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            int highestPriority = priorities[1];
            priorities[1] = priorities[last];
            last--;
            BubbleDown(1);

            return highestPriority;
        }

        private void BubbleUp(int index)
        {
            while (index > 1 && priorities[index] > priorities[index / 2])
            {
                Swap(index, index / 2);
                index = index / 2;
            }
        }

        private void BubbleDown(int index)
        {
            while (2 * index <= last)
            {
                int leftChild = 2 * index;
                int rightChild = 2 * index + 1;
                int largerChild = (rightChild <= last && priorities[rightChild] > priorities[leftChild]) ? rightChild : leftChild;

                if (priorities[index] >= priorities[largerChild])
                {
                    break;
                }

                Swap(index, largerChild);
                index = largerChild;
            }
        }
        private void Swap(int i, int j)
        {
            int temp = priorities[i];
            priorities[i] = priorities[j];
            priorities[j] = temp;
        }

        public void Display()
        {
            for (int i = 1; i <= last; i++)
                Console.Write(priorities[i] + " ");
            Console.WriteLine();
        }
    }
}
