using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba_15
{
    class Program
    {
        static void DupliranaVred(ref int prom)
        {
            prom *= 2;
            Console.WriteLine("duplirana promjenjiva = {0}", prom);
        }

        static void Main(string[] args)
        {
            int prom = 5;
            Console.WriteLine("Promjenjiva = {0}", prom);
            DupliranaVred(ref prom);
            Console.WriteLine("Promjenjiva = {0}", prom);
        }
    }
}
