using System;

namespace DoubleList
{
    class Program
    {
        static void Main()
        {
            BillList list = new BillList();
            Student a = new Student("Tom", 4.7);
            Student b = new Student("Kim", 4.3);
            if (a == b)
                Console.WriteLine("Objects are EQUAL");
            else
                Console.WriteLine("Objects are NOT EQUAL");

            list.Append(a);
            list.Append(b);
            list.Append(new Student("Mia", 4.2));
            list.Append(new Student("Tea", 4.4));
            list.Append(new Student("Lea", 4.1));
            Student c = new Student("Kim", 4.3);
            list.Append(c);
            list.Append(new Student("Bob", 4.5));
            list.Append(new Student("Ena", 4.9));
            Console.WriteLine("Count: " + list.Count);
            list.Display();
            Console.WriteLine();
            if (list.Search(c))
                Console.WriteLine("Element is in the list.");
            else
                Console.WriteLine("Element is not in the list.");
            try
            {
                list.Remove(a);
                list.Remove(c);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            Console.WriteLine();

            Console.WriteLine("Count: " + list.Count);
            list.Display();

            Console.ReadKey();
        }
    }
}