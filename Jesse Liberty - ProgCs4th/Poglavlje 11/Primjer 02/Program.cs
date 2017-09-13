using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatchingAnException
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
            Console.WriteLine("Exit Func1...");
        }

        public void Func2()
        {
            Console.WriteLine("Enter Func2...");
            try
            {
                Console.WriteLine("Enter try block...");
                throw new System.Exception();
                Console.WriteLine("Exiting try block...");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught and handled.");
            }
            
            Console.WriteLine("Exit Func2...");
        }
    }
}
