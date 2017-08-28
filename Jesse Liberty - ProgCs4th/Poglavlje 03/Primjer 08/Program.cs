using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primjer_08
{
    class NestedIf
    {
        static void Main(string[] args)
        {
            int temp = 32;

            if(temp <= 32)
            {
                Console.WriteLine("Warning! Ice on road.");
                if(temp == 32)
                {
                    Console.WriteLine("temp exactly freezing, beware of water.");
                }
                else
                {
                    Console.WriteLine("Watch for back ice! Temp: {0}", temp);
                }//zavrsava else
            }//zavrsava if (temp <= 32)
        }//zavrsava main
    }//zavrsava class
}//zavrsava namespace
