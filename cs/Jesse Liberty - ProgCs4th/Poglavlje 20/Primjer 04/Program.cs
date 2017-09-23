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
                Console.WriteLine("Enter Decrementer");

                //ako brojac jos nije 10
                //tada oslobadja monitor za ostale dretve koje cekaju
                while(counter < 5)
                {
                    Console.WriteLine("[{0}] Decrementer 1. Counter: {1}. Wait", Thread.CurrentThread.Name, counter);
                    Monitor.Wait(this);
                }

                while(counter > 0)
                {
                    long temp = counter;
                    temp--;
                    Thread.Sleep(1);
                    counter = temp;
                    Console.WriteLine("[{0}] Decrementer 2. Counter: {1}", Thread.CurrentThread.Name, counter);
                }
            }
            finally
            {
                //Monitor.Pulse(this);
                Console.WriteLine("Exit Decrementer");
                Monitor.Exit(this);
                
            }
        }

        public void Incrementer()
        {
            try
            {
                //Monitor.Enter(this);
                while (counter < 10)
                {
                    Monitor.Enter(this);
                    Console.WriteLine("Enter Incrementer");
                    long temp = counter;
                    temp++;
                    Thread.Sleep(1);
                    counter = temp;
                    Console.WriteLine("[{0}] Incrementer. Counter: {1}", Thread.CurrentThread.Name, counter);
                    Monitor.Pulse(this);
                    Console.WriteLine("Exit Incrementer");
                    Monitor.Exit(this);
                }

                //za sada je dosta povecanja nek druga dretva preuzme monitor
                //Monitor.Pulse(this);
            }
            finally
            {
                //Console.WriteLine("[{0}] Exiting...", Thread.CurrentThread.Name);
                //Monitor.Exit(this);
            }
        }   
    }
}
