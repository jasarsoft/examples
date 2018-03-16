using System;

namespace Primjer03
{
    class Program
    {
        static void Main()
        {
            char c1 = 'A';
            char c2 = (char)66; //ASCII kod znaka B je 66
            char c3 = '\x0043'; //ASCII kod znaka C je 43 heksadecimalno
            char c4 = '\u0044';
            char plus = '+';

            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}",
                c1, plus, c2, plus, c3, plus, c4);
        }
    }
}
