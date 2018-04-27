using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba_11
{
    class Program
    {
        static int sumProm(params int[] vals)
        {
            int sum = 0;
            foreach(int prom in vals)
            {
                sum += prom;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int sum = sumProm(1, 5, 2, 9, 8);
            Console.WriteLine("Sumirana vrijednost je = {0}", sum);
        }
    }
}
