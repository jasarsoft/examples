using System;
using System.Threading;

namespace SharedResource
{
    class Program
    {
        private int counter = 0;

        static void Main()
        {
            //stvara instancu ove klase
            Program p = new Program();

            //izvodi se izvan saticke main klase
            p.DoTest();
        }

        public void DoTest()
        {
            Thread t1 = new Thread(new ThreadStart(Incrementer));
            t1.IsBackground = true;
            t1.Name = "ThreadOne";
            t1.Start();
            Console.WriteLine("Stared thread {0}", t1.Name);

            Thread t2 = new Thread(new ThreadStart(Incrementer));
            t2.IsBackground = true;
            t2.Name = "ThreadTwo";
            t2.Start();
            Console.WriteLine("Stared thread {0}", t2.Name);

            t1.Join();
            t2.Join();

            //kada su ove dretve gotove ispisuje poruku
            Console.WriteLine("All my threads are done.");
        }

        //pokazna metoda broji do 1k
        public void Incrementer()
        {
            try
            {
                while(counter < 1000)
                {
                    //int temp = counter;
                    //temp++; //povecanje

                    //int temp = Interlocked.Increment(ref counter);

                    int temp;
                    lock(this)
                    {
                        temp = counter;
                        temp++;
                        Thread.Sleep(1);
                        counter = temp;
                    }

                    //simulira obavljanje posla
                    //Thread.Sleep(0);

                    //pridruzuje povecanu vrijednost i prikazuje rezultat
                    //counter = temp;
                    Console.WriteLine("{0} Incrementer: {1}", Thread.CurrentThread.Name, counter);
                }
            }
            catch (ThreadInterruptedException)
            {
                Console.WriteLine("{0} interrupted.", Thread.CurrentThread.Name);
            }
            finally
            {
                Console.WriteLine("{0} exiting.", Thread.CurrentThread.Name);
            }
        }
    }
}
