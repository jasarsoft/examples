using System;
namespace Primjer03
{
    public delegate void Signal(int v, long b);

    class Program
    {
        static void Main()
        {
            Operater r = new Operater();
            MobilePhone se = new MobilePhone(r);

            r.DolazniSignal(0, 38521);
            r.DolazniSignal(1, 38522);
        }
    }
}
