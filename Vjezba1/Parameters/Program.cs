using System;

namespace Parameters
{
    class Program
    {
        static void Main()
        {
            int a = 1;
            int b = 2;

            Console.WriteLine("a =" + a + " b = " + b);
            Swap(ref a, ref b);
            Console.WriteLine("a =" + a + " b = " + b);

            int[] numbers = { 2, 3, 4, 1, 8, 6, 5, 7 };

            Console.WriteLine("Before swapping:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Swap(ref numbers[2], ref numbers[3]);

            Console.WriteLine("After swapping:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}