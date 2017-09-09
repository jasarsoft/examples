using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IComperable
{
    //jednostavna klasa koja ce se cuvati u List
    class Employee : IComparable<Employee>
    {
        private int empID;

        public Employee(int empID)
        {
            this.empID = empID;
        }

        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }

        public override string ToString()
        {
            return empID.ToString();
        }

        public bool Equals(Employee other)
        {
            if (this.empID == other.empID)
                return true;
            else
                return false;
        }

        //CompareTo delegira natrag do employee
        //Employee koristi podrazumjevnu metodu CompareTo cjelobrojnih vrijednosti
        public int CompareTo(Employee rhs)
        {
            return this.empID.CompareTo(rhs.empID);
        }
    }
}
