using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba_07
{
    class Program
    {
        static void Main(string[] args)
        {
            double balans, intRata, ciljaniBalans;

            Console.Write("Koja je tvoja trenutna balans cijena?");
            balans = Convert.ToDouble(Console.ReadLine());

            Console.Write("Koja je tvoja godisnja kamatna stopa (u %)?");
            intRata = 1 + Convert.ToDouble(Console.ReadLine()) / 100;
            Console.Write("Koji balans bih zelio da dobijes?");
            ciljaniBalans = Convert.ToDouble(Console.ReadLine());

            int brojGodina = 0;
            while (balans < ciljaniBalans)
            {
                balans *= intRata;
                ++brojGodina;
            }

            Console.WriteLine("Za {0} godin{1} imate balans od {2}.", brojGodina, brojGodina == 1 ? "u" : "a", balans);
        }
    }
}
