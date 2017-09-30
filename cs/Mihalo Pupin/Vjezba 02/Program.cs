using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vjezba_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int mojInteger;
            string mojString;

            mojInteger = 17;
            mojString = "Moj cjeli broj \"mojInteger\" je: ";
            Console.WriteLine("{0} {1}.", mojString, mojInteger);

            mojInteger = +mojInteger;
            Console.WriteLine("mojInteger +: {0}", mojInteger);

            mojInteger = -mojInteger;
            Console.WriteLine("mojInteger -: {0}", mojInteger);

            int var1, var2 = 5, var3 = 6;
            var1 = var2++ * --var3;
            Console.WriteLine(var1);
        }
    }
}
