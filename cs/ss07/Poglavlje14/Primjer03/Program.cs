using System;

namespace Primjer03
{
    class Program
    {
        private int x = 50;

        unsafe static void Main()
        {
            Program t = new Program();

            fixed (int *p = &t.x)
            {
                
                Console.WriteLine(*p);
                GC.Collect();
                Console.WriteLine(*p);
            }
        }
    }
}
