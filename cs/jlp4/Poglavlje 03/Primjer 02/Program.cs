using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primjer_02
{
    class UnitializedVariable
    {
        static void Main(string[] args)
        {
            int myInt;
            System.Console.WriteLine("Uninitialized myInt: {0}", myInt);

            myInt = 5;
            System.Console.WriteLine("Assigned, myInt: {0}", myInt);
        }
    }
}
