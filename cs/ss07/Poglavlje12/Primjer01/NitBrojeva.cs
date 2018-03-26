using System;
using System.Threading;

namespace Primjer01
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
            for (int i = 1; i < 100000; i += 2)
                Console.WriteLine(i);
        }

        private void ParniBrojevi()
        {
            for (int i = 2; i < 100000; i += 2)
                Console.WriteLine(i);
        }
    }
}
