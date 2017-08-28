using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primjer_03
{
    class AssigningWithoutInitializing
    {
        static void Main(string[] args)
        {
            int myInt;
            myInt = 7;
            System.Console.WriteLine("Assigned myInt: {0}", myInt);

            myInt = 5;
            System.Console.WriteLine("Assigned myInt: {0}", myInt);
        }
    }
}
