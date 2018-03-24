using System;

namespace Primjer03._2
{
    class MobilePhone
    {
        public MobilePhone (Operater sig)
        {
            sig.Signalizirano += new Signal(SignalStigao);
        }

        private void SignalStigao(int vrsta, long broj)
        {
            if (vrsta == 0)
                Console.WriteLine("Stigao poziv od broja " + broj);
            else
                Console.WriteLine("Stigao SMS od broja " + broj);
        }
    }
}
