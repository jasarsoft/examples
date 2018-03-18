using System;

namespace Primjer05
{
    class TempClass
    {
        private int x;

        static TempClass()
        {
            Console.WriteLine("Staticki konstruktor");
        }

        public TempClass(int x)
        {
            this.x = x;
            Console.WriteLine("Kreiranje objekta");
        }
    }
}
