using System;

namespace Primjer01
{
    class Program
    {
        public delegate int Sortiranje(Girl g1, Girl g2);

        static void Main()
        {
            Sortiranje d1 = new Sortiranje(PoVisini);
            Sortiranje d2 = new Sortiranje(PoDatumu);

            PozivPoDelegatu(d1);
            PozivPoDelegatu(d2);
        }

        static int PoVisini(Girl g1, Girl g2)
        {
            return g1.Visina < g2.Visina ? -1 : 
                g1.Visina == g2.Visina ? 0 : 1;
        }

        static int PoDatumu(Girl g1, Girl g2)
        {
            return g1.DatumR < g2.DatumR ? -1 :
                g1.DatumR == g2.DatumR ? 0 : 1;
        }

        static int PoDatumu2(Girl g1, Girl g2)
        {
            if ((g1.DatumR.Year < g2.DatumR.Year) ||
                ((g1.DatumR.Year == g2.DatumR.Year) && (g1.DatumR.Month < g2.DatumR.Month)) ||
                ((g1.DatumR.Year == g2.DatumR.Year) && (g1.DatumR.Month == g2.DatumR.Month) && (g1.DatumR.Day < g2.DatumR.Day)))

                return 1;
            else if ((g1.DatumR.Year == g2.DatumR.Year) && (g1.DatumR.Month == g2.DatumR.Month) && (g1.DatumR.Day == g1.DatumR.Day))
                return 0;
            else
                return -1;
        }

        static void PozivPoDelegatu(Sortiranje met)
        {
            Girl ivana = new Girl(125, new DateTime(2000, 6, 24));
            Girl jelena = new Girl(110, new DateTime(2002, 11, 21));

            int ret = met(ivana, jelena);
            Console.WriteLine(ret < 0 ? "Ivana < Jelena" :
                ret == 0 ? "Ivana == Jelena" : "Ivana > Jelena");
        }
    }
}
