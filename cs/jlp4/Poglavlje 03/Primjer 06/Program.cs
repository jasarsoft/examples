using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primjer_06
{
    class CallingAMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In Main! Calling SomeMethod()...");
            SomeMethod();
            Console.WriteLine("Back in Main()");
        }

        static void SomeMethod()
        {
            Console.WriteLine("Grettings form SomeMethod!");
        }
    }
}
