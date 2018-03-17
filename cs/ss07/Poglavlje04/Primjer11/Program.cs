using System;
using System.Threading;

namespace Primjer11
{
    class Program
    {
        static void Main()
        {
            Random nekiBroj = new Random();

            while (nekiBroj.Next(100) != 50)
                ;
        }
    }
}
