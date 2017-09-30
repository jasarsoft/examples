using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IskazSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            const string mojeIme = "petar";
            const string mojePrezime = "petrovic";
            const string mojNadimak = "petko";

            string ime;
            Console.Write("Koje je tvoje ime: ");
            ime = Console.ReadLine();

            switch(ime.ToLower())
            {
                case mojeIme:
                    Console.WriteLine("Ti imas isto ime kao moje.");
                    break;
                case mojePrezime:
                    Console.WriteLine("Ti imas isto prezme kao moje.");
                    break;
                case mojNadimak:
                    Console.WriteLine("Ovo je veoma smjesan nadima.");
                    break;
            }

            Console.WriteLine("Pozdrav {0}!", ime);
        }
    }
}
