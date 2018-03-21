using System;

namespace Primjer03
{
    class Vrijeme
    {
        private byte sat = 0, minuta = 0, sekunda = 0;

        public Vrijeme(byte sat, byte minuta, byte sekunda)
        {
            this.sat = sat;
            this.minuta = minuta;
            this.sekunda = sekunda;
        }

        public byte Sat
        {
            get { return sat; }
        }

        public byte Minuta
        {
            get { return minuta; }
        }

        public byte Sekunda
        {
            get { return sekunda; }
        }
    }

    class Program
    {
        static void Main()
        {
            Vrijeme petDoDvanaest = new Vrijeme(11, 59, 55);
            Console.WriteLine("{0}:{1}:{2}", petDoDvanaest.Sat, petDoDvanaest.Minuta, petDoDvanaest.Sekunda);
        }
    }
}
