using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer01
{
    class TempClass
    {
        public int Count = 0;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int valTip1 = 10;
            int valTip2 = valTip1;
            valTip2 = 100;

            TempClass refTip1 = new TempClass();
            TempClass refTip2 = refTip1;
            refTip2.Count = 100;

            Console.WriteLine("{0}, {1}", valTip1, valTip2);
            Console.WriteLine("{0}, {1}", refTip1.Count, refTip2.Count);
        }
    }
}
