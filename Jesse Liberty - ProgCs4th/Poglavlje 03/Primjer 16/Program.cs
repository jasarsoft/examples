using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primjer_16
{
    class DivisionModulus
    {
        static void Main(string[] args)
        {
            int i1, i2;
            float f1, f2;
            double d1, d2;
            decimal dec1, dec2;

            i1 = 17;
            i2 = 4;
            f1 = 17F;
            f2 = 4F;
            d1 = 17;
            d2 = 4;
            dec1 = 17M;
            dec2 = 4M;

            Console.WriteLine("Integer:\t{0}\nFloat:\t{1}", i1 / i2, f1 / f2);
            Console.WriteLine("Double:\t{0}\nDecimal:\t{1}", d1 / d2, dec1 / dec2);
            Console.WriteLine("Modulus:\t{0}", i1 % i2);
        }
    }
}
