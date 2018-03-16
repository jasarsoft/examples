using System;

namespace Primjer07
{
    class TempClass
    {
        public int Counter;

        public TempClass(int x)
        {
            Counter = x;
        }
    }

    class Program
    {
        static void Main()
        {
            int val = 5;

            Console.WriteLine("Prije poziva funkcije: " + val);

            PromjeniVal(val);
            Console.WriteLine("Poslije poziva funkcije: " + val);
            Console.WriteLine();

            TempClass tmp = new TempClass(5);
            Console.WriteLine("Prije poziva funkcije: " + tmp.Counter);

            PromjeniRef(tmp);
            Console.WriteLine("Polije poziva funkcije: " + tmp.Counter);
        }

        static void PromjeniVal(int value)
        {
            value = 10;
        }

        static void PromjeniRef(TempClass value)
        {
            value.Counter = 10;
        }
    }
}
