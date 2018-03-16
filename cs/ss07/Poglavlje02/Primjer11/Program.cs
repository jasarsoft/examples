using System;

namespace Primjer11
{
    class TempClass
    {
        private int x;
    }

    class Program
    {
        static void Main()
        {
            int i = 35;
            TempClass tmp = new TempClass();

            Console.WriteLine(i.ToString());
            Console.WriteLine(tmp.ToString());
        }
    }
}
