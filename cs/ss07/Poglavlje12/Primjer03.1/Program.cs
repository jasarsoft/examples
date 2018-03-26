using System;
using System.Threading;

namespace Primjer03._1
{
    class Program
    {
        static void Main()
        {
            Count odbrojavanje = new Count();

            Thread t1 = new Thread(new ThreadStart(odbrojavanje.Counting2));
            t1.Start();

            Thread t2 = new Thread(new ThreadStart(odbrojavanje.Counting2));
            t2.Start();
        }
    }
}
