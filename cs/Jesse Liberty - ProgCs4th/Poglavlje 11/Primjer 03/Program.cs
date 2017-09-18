using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatchingExceptionInCallingFunc
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
            try
            {
                Console.WriteLine("Entering try block...");
                Func2();
                Console.WriteLine("Exiting try block...");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught and handled.");
            }
            
            Console.WriteLine("Exit Func1...");
        }

        public void Func2()
        {
            Console.WriteLine("Enter Func2...");
            throw new System.Exception();
            Console.WriteLine("Exit Func2...");
        }
    }
}
