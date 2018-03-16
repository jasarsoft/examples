using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer08
{
    class Program
    {
        static void Main()
        {
            String str = String.Format("{0} {1}", "PDV", "ukljucen");
            Console.WriteLine(str);

            int n = 2;
            str = String.Format("{0} {1} {2:d}. {3}", "PDV", "ukljucen", n, "put");
            Console.WriteLine(str);

            double cijenaKabla = 500.68;
            str = string.Format("{0, -20} {1,7:f}", "Cijena kabla je", cijenaKabla);
            Console.WriteLine(str);

            double cijenaUticnice = 15.68;
            str = String.Format("{0, -20} {1,7:f}", "Cijena uticnice je", cijenaUticnice);
            Console.WriteLine(str);

            str = String.Format("{0} {1:c}", "Cijena kabla je", cijenaKabla);
            Console.WriteLine(str);

            str = String.Format("{0} {1:d}", "Danas je", DateTime.Now);
            Console.WriteLine(str);

            str = String.Format("{0} {1:d}. {2}", "Danas je", DateTime.Now.DayOfYear, "dan u godini");
            Console.WriteLine(str);
        }
    }
}
