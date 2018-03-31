using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primjer_01
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Main...");
            Program p = new Program();
            p.Func1();
            Console.WriteLine("Exit Main...");
        }

        public void Func1()
        {
            Console.WriteLine("Enter Func1...");
            Func2();
            Console.WriteLine("Exit Func2...");
        }

        public void Func2()
        {
            Console.WriteLine("Enter Func2...");
            throw new System.Exception();
            Console.WriteLine("Exit Func2...");
        }
    }
}
