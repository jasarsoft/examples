using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mojArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            int maxProm = MaxVrijednost(mojArray);
            Console.WriteLine("Maksimalna vrijednost u nizu mojArray je {0}", maxProm);
        }

        static int MaxVrijednost(int[] intArray)
        {
            int maxProm = intArray[0];
            for(int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > maxProm)
                    maxProm = intArray[i];
            }

            return maxProm;
        }
    }
}
