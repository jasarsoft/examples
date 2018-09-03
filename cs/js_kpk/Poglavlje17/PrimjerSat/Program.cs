using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimjerSat
{
    class Program
    {
        struct Sat
        {
            private int vrijednost;

            public Sat(int pocetnaVrijednost)
            {
                vrijednost = pocetnaVrijednost;
            }

            public static Sat operator+ (Sat lop, Sat dop)
            {
                return new Sat(lop.vrijednost + dop.vrijednost);
            }

            public static Sat operator+ (Sat lop, int dop)
            {
                return lop + new Sat(dop);
            }

            public static Sat operator+ (int lop, Sat dop)
            {
                return new Sat(lop) + dop;
            }

            public static Sat operator++ (Sat arg)
            {
                arg.vrijednost++;
                return arg;
            }

            public static bool operator== (Sat lop, Sat dop)
            {
                return lop.vrijednost == dop.vrijednost;
            }

            public static bool operator!=(Sat lop, Sat dop)
            {
                return lop.vrijednost != dop.vrijednost;
            }

            public static implicit operator int (Sat iz)
            {
                return iz.vrijednost;
            }
        }

        public static void Metod(int parametar)
        {
            Console.WriteLine(parametar);
        }

        static void Main(string[] args)
        {
            Sat rucak = new Sat(12);
            Program.Metod(rucak); //implicitna konverzija iz Sat u int
            Program.Metod((int)rucak); //eksplicitna konverzija Sat u int
        }
    }
}
