using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListCollection
{
    class Program
    {
        static void Main()
        {
            List<int> intList = new List<int>();
            List<Employee> empList = new List<Employee>();

            //popunjava List
            for (int i = 0; i < 5; i++)
            {
                empList.Add(new Employee(i + 100));
                intList.Add(i * 5);
            }

            //ispisuje sav sadrzaj
            for(int i = 0; i < intList.Count; i++)
            {
                Console.Write("{0} ", intList[i].ToString());
            }

            Console.WriteLine();

            //ispisuje sav sadzaj Employee List
            for(int i = 0; i < empList.Count; i++)
            {
                Console.Write("{0} ", empList[i].ToString());
            }

            Console.WriteLine();

            Console.WriteLine("empList.Capacity: {0}", empList.Capacity);
        }
    }
}
