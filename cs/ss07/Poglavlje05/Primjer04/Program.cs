using System;

namespace Primjer04
{
    class Program
    {
        static void Main()
        {
            TempClass x = new TempClass();
            Console.WriteLine(x.BrojInstanci());

            TempClass y = new TempClass();
            Console.WriteLine(y.BrojInstanci());

            TempClass z = new TempClass();
            Console.WriteLine(z.BrojInstanci());
        }
    }
}
