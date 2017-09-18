using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IComparer
{
    class Program
    {
        static void Main()
        {
            List<Employee> empArray = new List<Employee>();

            //generira slucajne brojeve za cijelobrojne vrijednosti 
            //i identifikatore zaposlenika
            Random r = new Random();

            //popunjava polje
            for (int i = 0; i < 5; i++)
            {
                empArray.Add(new Employee(r.Next(10) + 100, r.Next(20)));
            }

            //prikazuje sad sadrzaj polja Employee
            for(int i = 0; i < empArray.Count; i++)
            {
                Console.Write("\n{0} ", empArray[i].ToString());
            }
            Console.WriteLine("\n");

            Employee.EmployeeComparer c = Employee.GetComparer();
            c.WhichComparasion = Employee.EmployeeComparer.ComparasionType.EmpID;
            empArray.Sort(c);

            //prikazuje sav sadrzaj Employee
            for (int i = 0; i < empArray.Count; i++)
            {
                Console.Write("\n{0} ", empArray[i].ToString());
            }
            Console.WriteLine("\n");

            c.WhichComparasion = Employee.EmployeeComparer.ComparasionType.Yrs;
            empArray.Sort(c);

            for (int i = 0; i < empArray.Count; i++)
            {
                Console.Write("\n{0} ", empArray[i].ToString());
            }
            Console.WriteLine("\n");
        }
    }
}
