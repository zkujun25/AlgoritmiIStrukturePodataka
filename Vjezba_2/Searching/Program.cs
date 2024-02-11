using System;

namespace Searching
{
    class Program
    {
        static void Main() {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("index: " + SequentialSearch(array, 6));
            Console.WriteLine("index: " + BinarySearch(array, 6, 0, 6));
            Console.WriteLine("index: " + BinarySearchIter(array, 6));
        }

        static int SequentialSearch(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    return i; // Return the index if value is found
            }

            return -1; // Return -1 if value is not found
        }

        static int BinarySearchIter(int[] array, int value)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (array[mid] == value)
                    return mid;

                if (array[mid] < value)
                    low = mid + 1;
                else
                    high = mid + 1;
            }

            return -1;
        }

        static int BinarySearch(int[] array, int value, int low, int high)
        {
            if (low > high) return -1;

            int mid = low + (high - low) / 2;

            if (array[mid] == value)
                return mid; // Return the index if value is found

            if (array[mid] < value)
            {
                low = mid + 1;
                return BinarySearch(array, value, low, high);
            }

            high = mid - 1;
            return BinarySearch(array, value, low, high);

        }
    }
}