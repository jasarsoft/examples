using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primjer_10
{
    class UsingGoto
    {
        static void Main(string[] args)
        {
            int i = 0;

            repeat: //oznaka
            Console.WriteLine("i: {0}", i);
            i++;
            if (i < 10)
                goto repeat; //zlodjelo
            return;
        }
    }
}
