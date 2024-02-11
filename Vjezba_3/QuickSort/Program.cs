using System;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;

namespace QuickSort
{
    public class Program
    {
        public static void Main()
        {
            Student[] students = {
             new Student ("Ivo", 4.1),
             new Student ("Ana", 4.9),
             new Student ("Iva", 4.3),
             new Student ("Bob", 4.5),
             new Student ("Joe", 4.7),
             new Student ("Tom", 4.4),
             new Student ("Iko", 4.6),
             };

            Display(students);

            Quick.Partition(students, 0, students.Length-1, Student.CompareName);

            Display(students);

            Quick.Sort(students, 0, students.Length - 1, Student.CompareName);

            Display(students);

            Quick.Sort(students, 0, students.Length - 1, Student.CompareGrade);

            Display(students);

        }

        public static void Display(object obj)
        {
            Student[] students = (Student[])obj;
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("----------");
        }
    }
}