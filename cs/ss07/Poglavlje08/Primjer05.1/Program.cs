﻿using System;
using System.Collections;

namespace Primjer05._1
{
    class Program
    {
        static void Main()
        {
            CollectionClass col = new CollectionClass();

            foreach (double d in col)
                Console.WriteLine(d);
        }
    }
}
