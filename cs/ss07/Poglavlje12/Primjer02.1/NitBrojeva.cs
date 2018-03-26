using System;
using System.Threading;

namespace Primjer02._1
{
    class NitBrojeva
    {
        private Thread t1;
        private Thread t2;

        public void PozoviNiti()
        {
            ThreadStart odds = new ThreadStart(NeparniBrojevi);
            ThreadStart evens = new ThreadStart(ParniBrojevi);

            t1 = new Thread(odds);
            t2 = new Thread(evens);

            t1.Start();
            t2.Start();
        }

        private void NeparniBrojevi()
        {
            //t2.Suspend();
            for (int i = 1; i < 100000; i += 2)
                Console.WriteLine(i);
            //t2.Resume();
        }

        private void ParniBrojevi()
        {
            t2.Suspend();
            for (int i = 2; i < 100000; i += 2)
                Console.WriteLine(i);
            t2.Resume();
        }
    }
}
