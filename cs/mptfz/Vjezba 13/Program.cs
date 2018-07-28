using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba_13
{
    class Program
    {
        static void Write()
        {
            string mojString = "String definisan u Write()";
            Console.WriteLine("Sada je u Write()");
            Console.WriteLine("mojString = {0}", mojString);
        }

        static void Main(string[] args)
        {
            string mojString = "String definisan u Main()";
            Write();
            Console.WriteLine("\nSada je u Main()");
            Console.Write("mojString = {0}", mojString);
        }
    }
}
