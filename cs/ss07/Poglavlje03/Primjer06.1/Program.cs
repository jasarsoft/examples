using System;


namespace Primjer06._1
{
    class Program
    {
        static void Main()
        {
            int x = 8; //1000
            int y = x >> 1; //0100 = 4
            Console.WriteLine("y = {0}", y);

            int z = x >> 2; //0010 = 2
            Console.WriteLine("z = {0}", z);

            x = 8; //001000
            y = x << 1; //010000 = 16
            Console.WriteLine("y = {0}", y);

            z = x << 2; //010000 = 32
            Console.WriteLine("z = {0}", z);
        }
    }
}
