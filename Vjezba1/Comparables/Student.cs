using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Comparables
{
    public class Student : IComparable<Student>
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
            return name + ": "  + grade;
        }

        public int CompareTo(Student other)
        {
            if (other == null)
                return 1;

            return grade.CompareTo(other.grade);
        }
    }
}
