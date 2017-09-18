using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingForEach
{
    class Program
    {
        static void Main()
        {
            int[] intArray;
            Employee[] empArray;

            intArray = new int[5];
            empArray = new Employee[3];

            //ispunjava polje
            for (int i = 0; i < empArray.Length; i++)
            {
                empArray[i] = new Employee(i + 5);
            }

            foreach(int i in intArray)
            {
                Console.WriteLine(i.ToString());
            }

            foreach(Employee e in empArray)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
