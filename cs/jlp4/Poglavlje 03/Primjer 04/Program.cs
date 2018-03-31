using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primjer_04
{
    class SymbolicConstants
    {
        static void Main(string[] args)
        {
            const int FreezingPoint = 32; //stupnjevi Fehrenheita
            const int BoilingPoint = 212;

            System.Console.WriteLine("Freezing point of water: {0}", FreezingPoint);
            System.Console.WriteLine("Boiling point of water: {0}", BoilingPoint);

            //BoilingPoint = 21;
        }
    }
}
