﻿using System;

namespace Primjer17
{
    class Program
    {
        static void Main()
        {
            for(int i = 1; i <= 100; i += 2)
            {
                if (i < 90)
                    continue;

                Console.Write(i + " ");
            }
        }
    }
}
