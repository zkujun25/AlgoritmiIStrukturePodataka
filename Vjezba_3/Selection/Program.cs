using System;
using System.Collections.Immutable;

namespace Selection
{
    public class Program
    {
        public static void Main()
        {
            int[] array = { 9, 8, 4, 11, 5, 7, 3, 1 };

            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------") ;

            Selection.Sort(array, 0);

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}