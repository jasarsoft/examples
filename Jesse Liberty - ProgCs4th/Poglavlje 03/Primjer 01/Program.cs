using System;
using System.Collections;
using System.Text;

namespace InitializingVariables
{
    class Values
    {
        static void Main()
        {
            int myInt = 7;
            System.Console.WriteLine("Initialized, myInt: {0}", myInt);

            myInt = 5;
            System.Console.WriteLine("Affter assigment, myInt: {0}", myInt);
        }
    }
}
