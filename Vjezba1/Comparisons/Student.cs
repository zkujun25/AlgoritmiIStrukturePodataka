using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Comparisons
{
    public class Student
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

        public static bool CompareName(object a, object b)
        {
            Student x = (Student)a;
            Student y = (Student)b;

            double result = x.name.CompareTo(y.name);
            if (result < 1)
                return true;
            return false;
        }

        public static bool CompareGrade(object a, object b)
        {
            Student x = (Student)a;
            Student y = (Student)b;

            double result = x.grade.CompareTo(y.grade);
            if (result < 1)
                return true;
            return false;
        }

    }
}
