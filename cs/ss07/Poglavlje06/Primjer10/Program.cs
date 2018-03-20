using System;

namespace Primjer10
{
    class Program
    {
        static double FiboRec(int n)
        {
            return (n == 0 || n == 1) ? n : FiboRec(n - 1) + FiboRec(n - 2);
        }

        static double Fibo(int n)
        {
            int prviBroj = 0, drugiBroj = 1;

            while(n-- != 0)
            {
                int tmp = prviBroj + drugiBroj;
                prviBroj = drugiBroj;
                drugiBroj = tmp;
            }

            return prviBroj;
        }

        static void Main()
        {
            int i = 40;

            DateTime start1 = DateTime.Now;
            Console.Write("{0}. clan = {1}", i, FiboRec(i));
            DateTime end1 = DateTime.Now;
            TimeSpan ts1 = end1 - start1;
            Console.WriteLine(" izracunat za " + ts1.Seconds + "." + ts1.Milliseconds + " sec");

            DateTime start2 = DateTime.Now;
            Console.Write("{0}. clan = {1}", i, Fibo(i));
            DateTime end2 = DateTime.Now;
            TimeSpan ts2 = end2 - start2;
            Console.WriteLine(" izracunat za " + ts2.Seconds + "." + ts2.Milliseconds + " sec");
        }
    }
}
