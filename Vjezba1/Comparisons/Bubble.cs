using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparisons
{
    delegate bool Comparison(object a, object b);
    class Bubble
    {
        public static void Sort(object[] array, Comparison comparison)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (comparison(array[j], array[i]))
                    {
                        object temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
        }
    }
}
