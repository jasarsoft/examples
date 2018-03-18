using System;

namespace Primjer07
{
    class Program
    {
        static void Main()
        {
            Bazna bazna = new Bazna();
            Izvedena derived = new Izvedena();

            bazna.BaseMethod();
            derived.BaseMethod();
        }
    }
}
