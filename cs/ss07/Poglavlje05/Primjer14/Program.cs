using System;

namespace Primjer14
{
    class Vanjska
    {
        private int x = 100;

        public class Unutarnja
        {
            public void fIn()
            {
                Vanjska v = new Vanjska();
                Console.WriteLine(v.x);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Vanjska.Unutarnja u = new Vanjska.Unutarnja();
            u.fIn();
        }
    }
}
