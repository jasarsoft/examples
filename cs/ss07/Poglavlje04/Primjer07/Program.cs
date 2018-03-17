using System;

namespace Primjer07
{
    class Program
    {
        static void Main()
        {
            int zbroj = 0, max = 1000;

            for (int i = 1; i <= max; i++)
                zbroj += i;

            Console.WriteLine("Zbroj prvih {0} brojeva je {1}", max, zbroj);
        }
    }
}
