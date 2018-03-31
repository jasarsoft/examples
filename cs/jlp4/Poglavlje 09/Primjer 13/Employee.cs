using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingConstraints
{
    class Employee : IComparable<Employee>
    {
        private string name;

        public Employee(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }

        //implementira sucelje
        public int CompareTo(Employee rhs)
        {
            return this.name.CompareTo(rhs.name);
        }

        public bool Equals(Employee rhs)
        {
            return this.name == rhs.name;
        }
    }
}
