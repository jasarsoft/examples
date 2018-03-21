using System;

namespace Primjer01
{
    class Planet
    {
        public const double Gravity = 9.80665;
    }

    class Program
    {
        static void Main()
        {
            double masa = 100;
            double tezina = masa * Planet.Gravity;

            Console.WriteLine("Tezina = " + tezina + " N");
        }
    }
}
