using System;

namespace Primjer05
{
    class Program
    {
        static void Main()
        {
            for (int i = 1900; i < 2100; i++)
            {
                if (!(i % 400 == 0) && !(i % 4 == 0 && i % 100 != 0))
                    Console.WriteLine(i + " nije prestupna");
                else
                    Console.WriteLine(i + " je prestupna");
            }
        }
    }
}
