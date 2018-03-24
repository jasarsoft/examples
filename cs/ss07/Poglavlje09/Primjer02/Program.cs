using System;

namespace Primjer02
{
    class Program
    {
        public delegate void Del(double d);

        static void Main()
        {
            Del d1 = new Del(F1);
            d1 += new Del(F2);
            d1(5);

            d1 -= new Del(F2);
            d1(6);
        }

        static void F1(double d)
        {
            Console.WriteLine(d);
        }

        static void F2(double d)
        {
            Console.WriteLine(d * 2);
        }
    }
}
