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

            Bubble.Sort(students);

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }

    }
}