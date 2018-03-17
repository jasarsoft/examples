using System;

namespace Primjer16
{
    class Program
    {
        static void Main()
        {
            int i, j;

            for(i = 0; i < 100; i++)
            {
                for(j = 0; j < 100; j++)
                {
                    if (i + j == 10)
                        break;
                }
            }
        }
    }
}
