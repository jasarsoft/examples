using System;

namespace Primjer09
{
    class Program
    {
        static void Main()
        {
            bool flagPrim = true;
            const int MAX = 1000;
            int brojPrimova = 0;

            for (int i = 1; i < MAX; i++)
            {
                for (int j = 2; j < i -1; j++)
                    if(i % j == 0)
                    {
                        flagPrim = false;
                        break;
                    }

                if (flagPrim)
                    brojPrimova++;

                flagPrim = true;
            }

            Console.WriteLine("Broj prim brojeva do {0} je {1}", MAX, brojPrimova);
        }
    }
}
