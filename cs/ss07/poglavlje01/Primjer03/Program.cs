using System;

namespace Primjer03
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
                return;

            int r1 = Convert.ToInt32(args[0]);
            int r2 = Convert.ToInt32(args[1]);

            Console.WriteLine("{0} Ohm", r1 * r2 / (r1 + r2));
        }
    }
}
