using System;

namespace Recursions
{
    class Program
    {
        static void Main() {
            int result = Factorial(6);

            Console.WriteLine("6! =  "+result);

            result = Fibonacci(6);

            Console.WriteLine("Fibonacci of 6 = " + result);

            result = FibonacciIter(6);

            Console.WriteLine("FibonacciIter of 6 = " + result); 
        }

        static int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }

        static int Fibonacci(int a)
        {
            if (a <= 0)
                return 0;
            else if (a == 1)
                return 1;
            else
                return Fibonacci(a - 1) + Fibonacci(a - 2);
        }

        static int FibonacciIter(int a)
        {
            if (a <= 0)
                return 0;
            else if (a == 1)
                return 1;

            int previous = 0;
            int current = 1;
            int next;

            for (int i = 2; i <= a; i++)
            {
                next = previous + current;
                previous = current;
                current = next;
            }

            return current;
        }

    }
}