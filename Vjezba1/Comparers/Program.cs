using Comparers;
using System;

namespace Comparables
{
    class Program
    {
        static void Main()
        {
            Student[] students = {
                new("Ivo", 4.1),
                new("Ana", 4.9),
                new("Iva", 4.3),
                new("Bob", 4.5),
                new("Joe", 4.7)
            };

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("----------");

            StudentComparer comparer = new StudentComparer(StudentComparerType.Name);

            Bubble.Sort(students, comparer);

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("----------");

            comparer = new StudentComparer(StudentComparerType.Grade);

            Bubble.Sort(students, comparer);

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }

    }
}