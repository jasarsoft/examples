using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomAttributes
{
    class Program
    {
        static void Main()
        {
            MyMath mm = new MyMath();

            Console.WriteLine("Calling DoFunc(7). Result: {0}", mm.DoFunc1(7));
        }
    }
}
