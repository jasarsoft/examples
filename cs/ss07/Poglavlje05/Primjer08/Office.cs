using System;

namespace Primjer08
{
    class Office
    {
        public void PokreniProgram()
        {
            Console.WriteLine("Office je pokrenut");
        }

        public virtual void SpremiDatoteku()
        {
            Console.WriteLine("Spremi office datoteku");
        }

        public void ZatvoriProgram()
        {
            Console.WriteLine("Office je zatvoren");
        }
    }
}
