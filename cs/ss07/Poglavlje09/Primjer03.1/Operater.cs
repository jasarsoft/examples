using System;

namespace Primjer03._1
{
    class Operater
    {
        public event Signal Signalizirano;

        public void DolazniSignal(int vrsta, long broj)
        {
            Signalizirano(vrsta, broj);
        }
    }
}
