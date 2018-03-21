using System;

namespace Primjer08
{
    class Program
    {
        static void Main()
        {
            KompleksniBroj kb1 = new KompleksniBroj(30, 40);
            KompleksniBroj kb2 = new KompleksniBroj(10, 25);
            KompleksniBroj kb3 = kb1 + kb2;

            Console.WriteLine(kb3);
            kb3++;
            Console.WriteLine(kb3);
            Console.WriteLine(kb1 - kb2);
            Console.WriteLine(kb1 == kb2);
        }
    }
}
