using System;

namespace Primjer06
{
    class Program
    {
        static void Main()
        {
            float f = (float)Math.Cos(0.00001);
            Console.WriteLine("Float: " + f);

            double d = Math.Cos(0.00001);
            Console.WriteLine("Double: " + d);

            decimal m = (decimal)Math.Cos(0.00001);
            Console.WriteLine("Decimal: " + m);
        }
    }
}
