using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Comparers
{
    enum StudentComparerType { Name, Grade }

    internal class StudentComparer(StudentComparerType criterion) : IComparer<Student>
    {
        StudentComparerType criterion = criterion;

        public int Compare(Student one, Student two)
        {
            if(criterion == StudentComparerType.Name) 
            {
                return one.ToString().CompareTo(two.ToString());
            }
            else if(criterion == StudentComparerType.Grade)
            {
                return one.CompareTo(two);
            }
            else
            {
                throw new ArgumentException("Invalid criterion.");
            }
        }
    }
}
