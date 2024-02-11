using PriorityQueue;
using System;

namespace Vjezba_3
{
    class Program
    {
        static void Main()
        {
            Heap heap = new Heap(10);

            try
            {
                for (int i = 0; i < 11; i++)
                    heap.Insert(i);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }

            heap.Display();

            try
            {
                while (true)
                {
                    int priority = heap.Retrieve();
                    heap.Display();
                }
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }


        }
    }
}