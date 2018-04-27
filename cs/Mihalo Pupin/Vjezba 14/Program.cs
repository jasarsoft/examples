using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string text = " ";
            for(i = 0; i < 10; i++)
            {
                text = "Linija " + Convert.ToString(i);
                Console.WriteLine("{0}", text);
            }
            Console.WriteLine("Posljednji text definisan u petlji: {0}", text);
        }
    }
}
