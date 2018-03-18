using System;

namespace Primjer07
{
    class Izvedena : Bazna
    {
        private int zCoord = 300;

        public Izvedena()
        {
            Console.Write("Izvedeni konstruktor, ");
            Console.WriteLine("x = {0}, y = {1}, z = {2}", XCoord, yCoord, zCoord);
        }
    }
}
