using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primjer_01
{
    public class Employee
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
    }
}
