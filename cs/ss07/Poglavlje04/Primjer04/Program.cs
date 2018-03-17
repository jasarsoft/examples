using System;

namespace Primjer04
{
    class Program
    {
        static void Main()
        {
            int x = 1;
            string text;

            if (x >= 0)
                if (x == 0)
                    text = "x je 0";
                else
                    text = "x je veci od 0";
            else
                text = "x je manji od 0";

            Console.WriteLine(text);
        }
    }
}
