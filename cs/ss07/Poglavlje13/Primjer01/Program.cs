using System;
using System.IO;
using System.Threading;

namespace Primjer01
{
    class Program
    {
        static void Main()
        {
            string spices = "Spice Girls";
            string[] spicesGirls =
            {
                "Melanie",
                "Geri",
                "Victoria",
                "Emma",
                "Melanie"
            };

            DirectoryInfo dir = new DirectoryInfo(spices);
            if (dir.Exists == false)
                dir.Create();

            foreach (string s in spicesGirls)
                dir.CreateSubdirectory(s);

            Console.WriteLine("Provjerite jesu li mape kreirane prije nego se izbrisu.");
            Thread.Sleep(20000);
            dir.Delete(true);
        }
    }
}
