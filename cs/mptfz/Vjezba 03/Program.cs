using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Promjenljive2
{
    class Program
    {
        static void Main(string[] args)
        {
            double prviBroj, drugiBroj;
            string userName;

            Console.Write("Unesi svoje ime: ");
            userName = Console.ReadLine();
            Console.WriteLine("Dobro dosli {0}!", userName);

            Console.Write("Unesite prvi broj: ");
            prviBroj = Convert.ToDouble(Console.ReadLine());

            Console.Write("Unesite drug broj: ");
            drugiBroj = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Suma broja {0} i {1} je: {2}", prviBroj, drugiBroj, prviBroj + drugiBroj);
            Console.WriteLine("Razlika broja {0} i {1} je: {2}", prviBroj, drugiBroj, prviBroj - drugiBroj);
            Console.WriteLine("Proizvod broja {0} i {1} je: {2}", prviBroj, drugiBroj, prviBroj * drugiBroj);
            Console.WriteLine("Rezultat djeljenja broja {0} i {1} je: {2}", prviBroj, drugiBroj, prviBroj / drugiBroj);
            Console.WriteLine("Ostatak djeljenja broja {0} i {1} je: {2}", prviBroj, drugiBroj, prviBroj % drugiBroj);
        }
    }
}
