using System;


namespace Primjer09
{
    class Program
    {
        static void Main()
        {
            int i = 100;
            object o = i;
            i = 200;

            Console.WriteLine("Tip int: {0}", i);
            Console.WriteLine("Tip object: {0}", o);
        }
    }
}
