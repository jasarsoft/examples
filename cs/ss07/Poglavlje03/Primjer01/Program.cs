using System;


namespace Primjer01
{
    class Program
    {
        static void Main()
        {
            int x = 7, y = 5;

            x += y;
            Console.WriteLine(x);

            x *= y;
            Console.WriteLine(x);

            x /= 4;
            Console.WriteLine(x);

            x -= 2;
            Console.WriteLine(x);

            x %= y;
            Console.WriteLine(x);
        }
    }
}
