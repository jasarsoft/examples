using System;
using System.Threading;

namespace UsingAMonitor
{
    class Program
    {
        private long counter = 0;

        static void Main()
        {
            //stvara instancu ove klase
            Program p = new Program();

            //izvodi se izvan saticke main klase
            p.DoTest();
        }

        public void DoTest()
        {
            //stvar polje dretvi bez imena
            Thread[] myThreads =
            {
                new Thread(new ThreadStart(Decrementer)),
                new Thread(new ThreadStart(Incrementer)),
            };

            //pokrece dretve
            int ctr = 1;
            foreach(Thread myThread in myThreads)
            {
                myThread.IsBackground = true;
                myThread.Name = "Thread " + ctr.ToString();
                myThread.Start();
                ctr++;
                Console.WriteLine("Started {0}", myThread.Name);
                Thread.Sleep(50);
            }

            //ceka da sve dretve zavrse prije nego nastavi dalje
            foreach(Thread myThread in myThreads)
            {
                myThread.Join();
            }

            //kada sve dretve zavrse nastavlja dalje
            Console.WriteLine("All my threads are done.");
        }

        public void Decrementer()
        {
            try
            {
                //sihrnonizira ovaj dio koda
                Monitor.Enter(this);

                //ako brojac jos nije 10
                //tada oslobadja monitor za ostale dretve koje cekaju
                if(counter < 10)
                {
                    Console.WriteLine("[{0}] Decrementer. Counter: {1}. Wait", Thread.CurrentThread.Name, counter);
                    Monitor.Wait(this);
                }

                while(counter > 0)
                {
                    long temp = counter;
                    temp--;
                    Thread.Sleep(1);
                    counter = temp;
                    Console.WriteLine("[{0}] Decrementer. Counter: {1}", Thread.CurrentThread.Name, counter);
                }
            }
            finally
            {
                Monitor.Exit(this);
            }
        }

        public void Incrementer()
        {
            try
            {
                Monitor.Enter(this);
                while (counter < 10)
                {
                    long temp = counter;
                    temp++;
                    Thread.Sleep(1);
                    counter = temp;
                    Console.WriteLine("[{0}] Increment. Counter: {1}", Thread.CurrentThread.Name, counter);
                }

                //za sada je dosta povecanja nek druga dretva preuzme monitor
                //Monitor.Pulse(this);
            }
            finally
            {
                Console.WriteLine("[{0}] Exiting...", Thread.CurrentThread.Name);
                Monitor.Exit(this);
            }
        }   
    }
}
