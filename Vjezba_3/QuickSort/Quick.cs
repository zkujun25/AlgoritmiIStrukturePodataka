using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    delegate bool Comparison(object a, object b);
    internal class Quick
    {
        public static void Sort(object[] array,int left,int right, Comparison cmp)
        {
            if (left >= right) return;
            int last = Partition(array, left, right, cmp);
            Sort(array, left, last - 1, cmp);
            Sort(array, last + 1, right, cmp);
        }

        public static int Partition(object[] array, int left, int right, Comparison cmp)
        {
            object pivot = array[right];
            int i = left-1;
            for (int j = left; j <= right - 1; j++)
            {
                if (cmp(array[j], pivot))
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            if (array[i+1] != array[right])
                Swap(array, i + 1, right);
            return i + 1;
        }

        public static void Swap(object[] array, int first, int second)
        {
            object temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

    }
}
