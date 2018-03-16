using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer10
{
    class Program
    {
        static void Main()
        {
            int i = 100;
            object o = i;

            int j = (int)o;

            Console.WriteLine("Tip int: {0}", j);
        }
    }
}
