using System;

namespace Primjer07
{
    class Program
    {
        static void Promjeni(out int i)
        {
            i = 11;
            return;
        }

        static void Main()
        {
            int x;
            Promjeni(out x);
            Console.WriteLine(x);
        }
    }
}
