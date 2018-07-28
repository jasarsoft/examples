using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} argumenta komande linije:", args.Length);
            foreach (string arg in args)
                Console.Write(arg);
        }
    }
}
