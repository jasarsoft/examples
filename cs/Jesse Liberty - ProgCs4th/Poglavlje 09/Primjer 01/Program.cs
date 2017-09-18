using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primjer_01
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

            for(int i = 0; i < intArray.Length - 1; i++)
            {
                Console.WriteLine(intArray[i].ToString());
            }

            for(int i = 0; i < empArray.Length - 1; i++)
            {
                Console.WriteLine(empArray[i].ToString());
            }
        }
    }
}
