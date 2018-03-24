using System;

namespace Primjer07
{
    class Program
    {
        static void Main()
        {
            int x = 2000000000, y = 2, z;

            try
            {
                z = checked(x * y);
            }
            catch (OverflowException e)
            {
                z = unchecked(x * y);
                Console.WriteLine(z);
            }
        }
    }
}
