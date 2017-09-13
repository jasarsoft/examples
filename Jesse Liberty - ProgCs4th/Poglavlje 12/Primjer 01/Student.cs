using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    public class Student
    {
        private string name;

        public Student(string name)
        {
            this.name = name;
        }

        //studenti se sortiraju abecedno
        public static Comparison WhichStudentComesFirst(Student s1, Student s2)
        {
            return (String.Compare(s1.name, s2.name) < 0 ? Comparison.theFirstComesFirst : Comparison.theSecondComesFirst);
        }

        public override string ToString()
        {
            return name;
        }
    }
}
