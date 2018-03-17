using System;

namespace Primjer03
{
    class Program
    {
        static void Main()
        {
            double result, kut = Math.PI / 6;

            result = kut < Math.PI ? Math.Sin(kut) : Math.Cos(kut);

            Console.WriteLine(result);
        }
    }
}
