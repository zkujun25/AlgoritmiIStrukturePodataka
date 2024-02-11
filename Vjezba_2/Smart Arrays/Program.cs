using System;
using System.Collections;

namespace Smart_Arrays
{
    class Program
    {
        static void Main()
        {
            SmartArray smarty = new SmartArray(6);

            for (int i = 0; i < 8; i++)
            {
                smarty.Add(i);
            }

            foreach (var item in smarty)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            IEnumerator enumerator = smarty.GetEnumerator();
            while (enumerator.MoveNext())
            {
                int i = (int)enumerator.Current;
                Console.Write(i + " ");
            }
            Console.WriteLine();

            for(int i = 0; i < 8; i++)
            {
                Console.WriteLine("Removing "+ i);
                smarty.Remove(i);

                foreach (var x in smarty)
                {
                    Console.Write(x + " ");
                }

                Console.WriteLine();
            }
        }
    }
}