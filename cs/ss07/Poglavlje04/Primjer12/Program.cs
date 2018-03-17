using System;

namespace Primjer12
{
    class Program
    {
        static void Main()
        {
            int x;

            Random nekiBroj = new Random();

            while ((x = nekiBroj.Next(100)) != 50)
                Console.WriteLine(x);
        }
    }
}
