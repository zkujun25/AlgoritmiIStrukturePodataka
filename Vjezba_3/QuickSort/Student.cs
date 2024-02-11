using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Student
    {
        string name;
        double grade;

        public Student(string name, double grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public override string ToString()
        {
            return name + ": "+ grade;
        }

        public static bool CompareName(object first, object second)
        {
            Student one = (Student)first;
            Student two= (Student)second;
            return one.name.CompareTo(two.name) < 0;
        }

        public static bool CompareGrade(object first, object second)
        {
            Student one = (Student)first;
            Student two = (Student)second;
            return one.grade > two.grade;
        }


    }
}
