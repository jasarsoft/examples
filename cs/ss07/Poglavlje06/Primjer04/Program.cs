using System;

namespace Primjer04
{
    class Program
    {
        static void Promjeni(int i)
        {
            i = 11;
            return;
        }

        static void Main()
        {
            int x = 10;
            Console.WriteLine(x);
            Promjeni(x);
            Console.WriteLine(x);
        }
    }
}
