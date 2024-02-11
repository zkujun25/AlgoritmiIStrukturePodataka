using Heap;
using System;

namespace Heap
{
    class Program
    {
        static void Main()
        {
            int[] array = { 5, 6, 8, 3, 4, 2, 1, 7, 3, 5, 4, 5, 4, 8 };

            Display(array);

            Heap.Sort(array);

            Display(array);
        }

        private static void Display(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}