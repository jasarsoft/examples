using System;
using System.Threading;

namespace Primjer03
{
    class Count
    {
        public static int counter = 100;

        public void Counting1()
        {
            while(Count.counter > 0)
            {
                int x = Count.counter;
                x--;
                Thread.Sleep(5);
                Count.counter = x;
                Console.WriteLine(Count.counter);
            }
        }

        public void Counting2()
        {
            while(Count.counter > 0)
            {
                int x = Count.counter;
                x--;
                Thread.Sleep(5);
                Count.counter = x;
                Console.WriteLine(Count.counter);
            }
        }
    }
}
