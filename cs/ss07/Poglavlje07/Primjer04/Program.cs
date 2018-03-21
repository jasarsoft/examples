using System;

namespace Primjer04
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

        public void SetTime(Time t)
        {
            t.ChangeTime(this);
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

    class Time
    {
        private byte sat = 0, minuta = 0, sekunda = 0;

        public void ChangeTime(Vrijeme v)
        {
            sat = v.Sat;
            minuta = v.Minuta;
            sekunda = v.Sekunda;
            Console.WriteLine("{0}:{1}:{2}", sat, minuta, sekunda);
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
            Time noTIme = new Time();
            petDoDvanaest.SetTime(noTIme);
        }
    }
}
