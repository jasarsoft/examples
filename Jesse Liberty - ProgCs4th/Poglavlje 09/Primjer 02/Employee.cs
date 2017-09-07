using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingForEach
{
    public class Employee
    {
        //jednostavna klasa koja ce pohranjivati u polje
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
