using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace boxing
{
    class Program
    {
        static void Main()
        {
            int i = 123;

            //pakiranje (implicitno)
            object o = i;

            //raspakiravanje (mora biti eksplicitno)
            int j = (int)o;
            Console.WriteLine("j: {0}", j);
        }
    }
}
