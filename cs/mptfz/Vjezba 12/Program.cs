using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba_12
{
    class Program
    {
        static void Write()
        {
            Console.WriteLine("mojString = {0}", mojString);
        }

        static void Main(string[] args)
        {
            string mojString = "String koji je definisan u f-ju Main()";
            Write();
        }
    }
}
