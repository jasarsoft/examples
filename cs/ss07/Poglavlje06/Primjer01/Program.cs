using System;

namespace Primjer01
{
    class Program
    {
        static double KompleksnaVrijednost(double real, double im)
        {
            double d = Math.Sqrt(real * real + im * im);
            return d;
        }
        static void Main()
        {
            double real = 6.7, imagine = 5.3;
            double apsolute = KompleksnaVrijednost(real, imagine);

            Console.WriteLine(apsolute);

        }
    }
}
