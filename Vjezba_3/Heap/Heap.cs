using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    internal class Heap
    {
        public static void Sort(int[] array)
        {
            Heapify(array);
            Arrange(array);
        }

        public static void Heapify(int[] array)
        {
            int n = array.Length;
            for(int i = n / 2 - 1; i>= 0; i--)
            {
                BubbleDown(array, i, n- 1);
            }
        }

        public static void Arrange(int[] array)
        {
            int n = array.Length;
            for(int i = n - 1; i >= 0; i--)
            {
                Swap(array, 0, i);
                BubbleDown(array, 0, i - 1);
            }
        }

        public static void BubbleDown(int[] array, int i, int last)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left <= last && array[left] > array[largest])
                largest = left;
            if (right <= last && array[right] > array[largest])
                largest = right;

            if(largest != i)
            {
                Swap(array, i, largest);
                BubbleDown(array, largest, last);
            }
        }

        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
