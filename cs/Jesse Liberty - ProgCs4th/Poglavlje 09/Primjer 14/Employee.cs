using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListCollection
{
    //jednostavna klasa koja ce se cuvati u List
    class Employee
    {
        private int empID;

        public Employee(int empID)
        {
            this.empID = empID;
        }

        public override string ToString()
        {
            return empID.ToString();
        }

        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }
    }
}
