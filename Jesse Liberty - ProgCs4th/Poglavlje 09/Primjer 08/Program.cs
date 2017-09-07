using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertingArrays
{
    class Program
    {
        static void Main()
        {
            //pravi polje Employee objektata
            Employee[] myEmployeeArray = new Employee[3];

            //inicijalizira vrijednost svakog Employee
            for(int i = 0; i < 3; i++)
            {
                myEmployeeArray[i] = new Employee(i + 5);
            }

            //prikazuje vrijednosti
            Tester.PrintArray(myEmployeeArray);

            //pravi polje od dva niza
            string[] array =
            {
                "hello", "world"
            };

            //ispisuje vrijednost nizova
            Tester.PrintArray(array);
        }
    }
}
