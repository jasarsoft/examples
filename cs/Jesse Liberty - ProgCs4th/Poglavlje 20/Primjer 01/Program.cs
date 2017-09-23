using System;
using System.Threading;

namespace Primjer_01
{
    class Program
    {
        static void Main()
        {
            //pravi instancu klase 
            Program p = new Program();

            Console.WriteLine("hello");

            //izvodi se izvan staticke metode main
            p.DoTest();
        }

        public void DoTest()
        {
            //stvara dretvu za incramenter
            //prosljedjuje ThreadStart delegata s adresom Incrementera
            Thread t1 = new Thread(new ThreadStart(Incrementer));

            //stvara dretvu za decrementer
            //prosljedjuje delegata ThreadStart s adresom Decrementer
            Thread t2 = new Thread(new ThreadStart(Decrementer));

            //pokrece dretve
            t1.Start();
            t2.Start();
        }

        //pokazna metoda broji do 1k
        public void Incrementer()
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Incrementer: {0}", i);
            }
        }

        //pokazna metoda broji unatrag od 1k
        public void Decrementer()
        {
            for(int i = 1000; i >= 0; i--)
            {
                Console.WriteLine("Decrementer: {0}", i);
            }
        }
    }
}
