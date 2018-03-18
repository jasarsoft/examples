using System;

namespace Primjer06
{
    class Program
    {
        static void Main()
        {
            Planet uranius = new Planet("Uran", false, true);
            uranius.Life = true;

            Console.WriteLine("Na Uranu {0} izovota", uranius.Life == true ? "ima" : "nema");
        }
    }
}
