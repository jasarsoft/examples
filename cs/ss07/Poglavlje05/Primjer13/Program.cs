using System;

namespace Primjer13
{
    struct SKoordinate
    {
        public int xCoord, yCoord;

        public SKoordinate(int x, int y)
        {
            xCoord = x;
            yCoord = y;
        }
    }

    class CKoordinate
    {
        public int xCoord, yCoord;

        public CKoordinate(int x, int y)
        {
            xCoord = x;
            yCoord = y;
        }
    }

    class Program
    {
        static void Main()
        {
            const int NUM = 10000000;
            DateTime start = DateTime.Now;

            SKoordinate[] s = new SKoordinate[NUM];
            for (int i = 0; i < NUM; i++)
                s[i] = new SKoordinate(i, i);

            DateTime end1 = DateTime.Now;
            TimeSpan ts1 = end1 - start;
            Console.WriteLine("Strukture kreirane za {0}.{1} sec", ts1.Seconds, ts1.Milliseconds);

            CKoordinate[] c = new CKoordinate[NUM];
            for (int i = 0; i < NUM; i++)
                c[i] = new CKoordinate(i, i);

            DateTime end2 = DateTime.Now;
            TimeSpan ts2 = end2 - start;
            Console.WriteLine("Klase kreirane za {0}.{1} sec", ts2.Seconds, ts2.Milliseconds);
        }
    }
}
