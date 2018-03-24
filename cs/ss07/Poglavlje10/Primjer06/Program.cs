using System;

namespace Primjer06
{
    class Program
    {
        static void Main()
        {
            sbyte x = 127, y;

            try
            {
                y = checked(++x);
            }
            catch (OverflowException e)
            {
                y = x;
            }

            Console.WriteLine(y);
        }
    }
}
