using System;

namespace Primjer02
{
    class Planet
    {
        private readonly double gravity;

        public Planet(double d)
        {
            gravity = d;
        }

        public double Gravity
        {
            get { return gravity; }
        }
    }

    class Program
    {
        static void Main()
        {
            double masa = 100;
            Planet earth = new Planet(9.80665);
            Planet jupiter = new Planet(22.94756);

            double tezinaZemlja = masa * earth.Gravity;
            double tezinaJupiter = masa * earth.Gravity;

            Console.WriteLine("Tezina na Zemlji = {0} N", tezinaZemlja);
            Console.WriteLine("Tezina na Jupiteru = {0} N", tezinaJupiter);
        }
    }
}
