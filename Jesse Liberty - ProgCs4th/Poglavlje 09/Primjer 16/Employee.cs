using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IComparer
{
    public class Employee : IComparable<Employee>
    {
        private int empID;
        private int yearsOfSvc = 1;

        public Employee(int empID)
        {
            this.empID = empID;
        }

        public Employee(int empID, int yearsOfSvc)
        {
            this.empID = empID;
            this.yearsOfSvc = yearsOfSvc;
        }

        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }

        public override string ToString()
        {
            return "ID: " + empID.ToString() + ". Years of Svc: " + yearsOfSvc;
        }

        public bool Equals(Employee other)
        {
            if (this.empID == other.empID)
                return true;
            else
                return false;
        }

        //staticka metoda za uzimanje objekta Comparer
        public static EmployeeComparer GetComparer()
        {
            return new Employee.EmployeeComparer();
        }

        //CompareTo delegira natrag employee
        //Employee koristi podrazumjevnu metodu CompareTo cjelobrojnih vrijednosti
        public int CompareTo(Employee rhs)
        {
            return this.empID.CompareTo(rhs.empID);
        }

        //posebna implementacija koju ce pozvati prilagodjeni usporedjivac
        public int CompareTo(Employee rhs, EmployeeComparer.ComparasionType which)
        {
            switch(which)
            {
                case Employee.EmployeeComparer.ComparasionType.EmpID:
                    return this.empID.CompareTo(rhs.empID);
                case EmployeeComparer.ComparasionType.Yrs:
                    return this.yearsOfSvc.CompareTo(rhs.yearsOfSvc);
            }

            return 0;
        }

        //ugnjezdena klasa koja implementira IComparer
        public class EmployeeComparer : IComparer<Employee>
        {
            //privatna varijabla stanja
            private ComparasionType whichComparasion;

            //enumeracija tipova za usporedjivanje
            public enum ComparasionType
            {
                EmpID,
                Yrs
            };


            public ComparasionType WhichComparasion
            {
                get { return whichComparasion; }
                set { whichComparasion = value; }
            }


            public bool Equals(Employee lhs, Employee rhs)
            {
                return this.Compare(lhs, rhs) == 0;
            }

            public int GetHashCode(Employee e)
            {
                return e.GetHashCode();
            }

            //govori objektima employee da se usporede
            public int Compare(Employee lhs, Employee rhs)
            {
                return lhs.CompareTo(rhs, whichComparasion);
            } 
        }
    }
}
