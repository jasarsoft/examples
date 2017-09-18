using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queue
{
    class Program
    {
        static void Main()
        {
            Queue<Int32> intQueue = new Queue<int>();

            //popunjava polje
            for (int i = 0; i < 5; i++)
            {
                intQueue.Enqueue(i * 5);
            }

            //prikazuje red
            Console.Write("intQueue values:\t");
            PrintValues(intQueue);

            //brise element iz reda
            Console.WriteLine("\n(Dequene)\t{0}", intQueue.Dequeue());
            Console.Write("intQueue values:\t");
            PrintValues(intQueue);

            //brise jos jedan element iz reda
            Console.WriteLine("\n(Dequene)\t{0}", intQueue.Dequeue());
            Console.Write("intQueue values:\t");
            PrintValues(intQueue);

            //pregled prvog elementa u redu ali ga ne uklanja
            Console.WriteLine("\n(Peek)\t{0}", intQueue.Peek());
            Console.Write("intQueue values:\t");
            PrintValues(intQueue);
        }

        public static void PrintValues(IEnumerable<Int32> myCollection)
        {
            IEnumerator<Int32> myEnumerator = myCollection.GetEnumerator();
            while(myEnumerator.MoveNext())
            {
                Console.Write("{0} ", myEnumerator.Current);
            }
            Console.WriteLine();
        }
    }
}
