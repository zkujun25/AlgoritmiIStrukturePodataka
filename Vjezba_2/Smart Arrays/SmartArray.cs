using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Arrays
{
    internal class SmartArray
    {
        int size;
        int last = -1;
        int[] array;

        public SmartArray(int size)
        {
            array = new int[size];
            this.size = array.Length;
        }

        public int Length
        {
            get { return last + 1; }
        }

        public void Add(int item)
        {
            if (last == (size - 1))
            {
                Array resized =
               Array.CreateInstance(typeof(int), size * 2);
                Array.Copy(array, resized, size);

                array = (int[])resized;
                size = array.Length;
            }
            array[++last] = item;

        }

        public void Remove(int value)
        {
            for (int i = 0; i <= last; i++)
            {
                if (array[i] == value)
                {
                    Array.Copy(array, i + 1, array, i, last - i);
                    last--;
                    break;
                }
            }
            
        }

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            return new SmartEnumerator(this);
        }

        private class SmartEnumerator : IEnumerator, IDisposable
        {
            int index = -1;
            SmartArray smarty;

            public SmartEnumerator(SmartArray smarty)
            {
                this.smarty = smarty;
            }

            public bool MoveNext()
            {
                index++;
                return index < smarty.Length;
            }

            public void Reset()
            {
                throw new NotSupportedException();
            }

            public object Current
            {
                get
                {
                    return smarty.array[index];
                }
            }

            public void Dispose() { }

        }

        

    }
}
