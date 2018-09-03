using System;

namespace PrimjerUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = Util.Min(4, 9);
            Console.WriteLine(min);

            min = Util.Min(7, 5, 10);
            Console.WriteLine(min);
        }
    }
}
