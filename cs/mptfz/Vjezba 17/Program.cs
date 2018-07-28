using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba_17
{
    class Program
    {
        delegate double procesDelegati(double param1, double param2);

        static double Pomnozi(double param1, double param2)
        {
            return param1 * param2;
        }

        static double Podjeli(double param1, double param2)
        {
            return param1 / param2;
        }

        static void Main(string[] args)
        {
            procesDelegati process;
            Console.WriteLine("Unesi dva broja razdvojena zarezom:");
            string ulaz = Console.ReadLine();
            int pozZarezta = ulaz.IndexOf(",");
            double param1 = Convert.ToDouble(ulaz.Substring(0, pozZarezta));
            double param2 = Convert.ToDouble(ulaz.Substring(pozZarezta + 1, ulaz.Length - pozZarezta - 1));
            Console.WriteLine("Pritisni taster M za mnozenje ili D za djeljenje");
            ulaz = Console.ReadLine();
            if (ulaz == "M")
            {
                process = new procesDelegati(Pomnozi);
                Console.WriteLine("Rezultat je: {0}", process(param1, param2));
            }
            else if (ulaz == "D")
            {
                process = new procesDelegati(Podjeli);
                Console.WriteLine("Rezultat je: {0}", process(param1, param2));
            }
            else
                Console.WriteLine("Niste dobro izabrali operaciju!");
        }
    }
}
