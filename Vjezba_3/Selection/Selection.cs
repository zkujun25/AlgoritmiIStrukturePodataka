using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    internal class Selection
    {
        public static void Sort(int[] array, int index)
        {
            int length = array.Length; 

            for(int i = index; i < length-1; i++)
            {
                int minIndex = i;
                for(int j = i+1; j<length; j++)
                {
                    if (array[j] < array[i])
                        minIndex = j;
                }

                if(minIndex != i)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
        }
    }
}
