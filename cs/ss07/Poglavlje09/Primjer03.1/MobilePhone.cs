using System;

namespace Primjer03._1
{
    class MobilePhone
    {
        public MobilePhone (Operater sig)
        {
            sig.Signalizirano += new Signal(SignalStigao1);
            sig.Signalizirano += new Signal(SignalStigao2);
        }

        private void SignalStigao1(int vrsta, long broj)
        {
            Console.WriteLine(vrsta == 0 ? "Stigao poziv " : "Stigao SMS");
        }

        private void SignalStigao2(int vrsta, long broj)
        {
            Console.WriteLine(broj);
        }
    }
}
