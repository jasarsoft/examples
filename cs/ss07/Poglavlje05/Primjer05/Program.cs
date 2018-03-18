using System;

namespace Primjer05
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Prije kreiranje objekta");
            TempClass x = new TempClass(5);
            Console.WriteLine("Poslije kreiranje objekta");
        }
    }
}
