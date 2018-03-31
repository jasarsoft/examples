using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primjer_11
{
    class WhileLoop
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 10)
            {
                Console.WriteLine("i: {0}", i);
                i++;
            }
            return;
        }
    }
}
