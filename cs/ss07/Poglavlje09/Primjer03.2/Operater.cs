using System;

namespace Primjer03._2
{
    class Operater
    {
        public event Signal Signalizirano;

        public virtual void DolazniSignal(int vrsta, long broj)
        {
            Signalizirano(vrsta, broj);
        }
    }
}
