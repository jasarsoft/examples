using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IComperable
{
    class Program
    {
        static void Main()
        {
            List<Int32> intArray = new List<int>();
            List<Employee> empArray = new List<Employee>();

            //generira slucajne brojeve za cjelobrojne vrijednosti
            //i identifikatore zaposlenika
            Random r = new Random();

            //popunjava polje
            for(int i = 0; i < 5; i++)
            {
                //dodaje slucajni indentifikator zaposlenika
                empArray.Add(new Employee(r.Next(10) + 100));

                //dodaje slucajnu cjelobrojnu vrijednost
                intArray.Add(r.Next(10));
            }

            //prikazuje sav sadrzaj polja cjelobrojnih vrijednosti
            for(int i = 0; i < intArray.Count; i++)
            {
                Console.Write("{0} ", intArray[i].ToString());
            }
            Console.WriteLine();

            //prikazuje sav sadzaj polja Employee
            for(int i = 0; i < empArray.Count; i++)
            {
                Console.Write("{0} ", empArray[i].ToString());
            }
            Console.WriteLine("\n");

            //sortira i prikazuje polje cjelobrojnih vrijednosti
            intArray.Sort();
            for(int i = 0; i < intArray.Count; i++)
            {
                Console.Write("{0} ", intArray[i].ToString());
            }
            Console.WriteLine();

            //sortira i prikazuje polje zapozlenika
            empArray.Sort();
            for(int i = 0; i < empArray.Count; i++)
            {
                Console.Write("{0} ", empArray[i].ToString());
            }
            Console.WriteLine();
        }
    }
}
