using System;
using System.Threading;

namespace Primjer_02
{
    class Program
    {
        static void Main()
        {
            //pravi instancu klase 
            Program p = new Program();

            //izvodi se izvan staticke metode main
            p.DoTest();
        }

        public void DoTest()
        {
            //stvar polje dretvi bez imena
            Thread[] myThreads =
            {
                new Thread(new ThreadStart(Decrementer)),
                new Thread(new ThreadStart(Incrementer)),
                new Thread(new ThreadStart(Decrementer)),
                new Thread(new ThreadStart(Incrementer))
            };

            //pokrece dretve
            int ctr = 1;
            foreach (Thread myThread in myThreads)
            {
                myThread.IsBackground = true;
                myThread.Name = "Thread " + ctr.ToString();
                myThread.Start();
                Console.WriteLine("Started {0}", myThread.Name);
                ctr++;
                Thread.Sleep(50);
            }

            //zahtjeva prekidanje prve dretve
            myThreads[0].Interrupt();

            //odmah prekida drugu dretvu
            myThreads[1].Abort();

            //ceka da zavrse sve dretve prije nego nastavi
            foreach(Thread myThread in myThreads)
            {
                myThread.Join();
            }

            //nakon sto sve dretver zavrse ispisuje poruku
            Console.WriteLine("All my threads are done.");  
        }

        //pokazna metoda broji do 100
        public void Incrementer()
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("- {0}. Incrementer: {1}", Thread.CurrentThread.Name, i);
                    Thread.Sleep(1);
                }
            }
            catch(ThreadAbortException)
            {
                Console.WriteLine("Incrementer | {0} aborted!", Thread.CurrentThread.Name);
            }
            catch (Exception)
            {
                Console.WriteLine("Incrementer | {0} has been interrupted.", Thread.CurrentThread.Name);
            }
            finally
            {
                Console.WriteLine("Incrementer | {0} exiting.", Thread.CurrentThread.Name);
            }            
        }

        //pokazna metoda broji unatrag od 100
        public void Decrementer()
        {
            try
            {
                for (int i = 100; i >= 0; i--)
                {
                    Console.WriteLine("- {0}. Decrementer: {1}", Thread.CurrentThread.Name, i);
                    Thread.Sleep(1);
                }
            }
            catch (ThreadAbortException)
            {
                Console.WriteLine("Decrementer | {0} aborted!", Thread.CurrentThread.Name);
            }
            catch (Exception)
            {
                Console.WriteLine("Decrementer | {0} has been interrupted.", Thread.CurrentThread.Name);
            }
            finally
            {
                Console.WriteLine("Decrementer | {0} exiting.", Thread.CurrentThread.Name);
            }
        }
    }
}
