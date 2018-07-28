using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IskazIf
{
    class Program
    {
        static void Main(string[] args)
        {
            string komparacija;

            Console.Write("Unesi prvi cijeli broj: ");
            double prom1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Unesi drugi cijeli broj: ");
            double prom2 = Convert.ToDouble(Console.ReadLine());

            if (prom1 < prom2)
                komparacija = "manji";
            else
            {
                if (prom1 == prom2)
                    komparacija = "jednak";
                else
                    komparacija = "veci";
            }

            Console.WriteLine("Prvi broj je {0} od drugog broja.", komparacija);
        }
    }
}
