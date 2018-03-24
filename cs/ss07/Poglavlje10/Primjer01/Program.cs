using System;

namespace Primjer01
{
    class Program
    {
        static void Main()
        {
            int x = 1;
            Random r = new Random();

            for(int i = 0; i < 100; i++)
            {
                int y = r.Next(100);

                try
                {
                    int z = x / y;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Pokusaj djeljenja sa nulom");
                }
            }


        }
    }
}
