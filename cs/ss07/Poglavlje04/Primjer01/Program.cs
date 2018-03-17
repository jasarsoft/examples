using System;

namespace Primjer01
{
    class Program
    {
        static void Main()
        {
            int x = 20, y, z;

            if(x == 20)
            {
                y = 10;
                z = 100;
            }
            else
            {
                y = 11;
                z = 101;
            }

            Console.WriteLine(y + z);
        }
    }
}
