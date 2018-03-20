using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer05
{
    class Program
    {
        static void Promjeni(ref int i)
        {
            i = 11;
            return;
        }

        static void Main()
        {
            int x = 10;
            Console.WriteLine(x);
            Promjeni(ref x);
            Console.WriteLine(x);
        }
    }
}
