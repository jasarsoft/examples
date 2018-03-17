using System;

namespace Primjer15
{
    class Program
    {
        static void Main()
        {
            int i;
            long faktorijel = 1;

            for (i = 1; i < 100; i++)
            {
                if(faktorijel > 1000000)
                {
                    faktorijel /= (i - 1);
                    break;
                }

                faktorijel *= i;
            }

            Console.WriteLine("{0}! = {1}", i - 2, faktorijel);
        }
    }
}
