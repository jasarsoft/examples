using System;

namespace Primjer02
{
    class Program
    {
        static void Main()
        {
            int x = 7, y = 5;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", 
                (x += y), (x *= y), (x /= y), (x -= 2), (x %= y));
        }
    }
}
