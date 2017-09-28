using System;
using System.IO;

namespace AsynchronousIO
{
    class Program
    {
        static void Main()
        {
            //stvara instancu AsynchIOTester koja poziva konstruktor
            AsynchIOTester theApp = new AsynchIOTester();
            theApp.Run();
        }
    }
}
