using System;

namespace Primjer07
{
    class Bazna
    {
        private int xCoord = 100;
        protected int yCoord = 200;

        public Bazna()
        {
            Console.Write("Bazni konstruktor, ");
            Console.WriteLine("x = {0}, y = {1}", xCoord, yCoord);
        }

        public int XCoord
        {
            get
            {
                return xCoord;
            }
        }

        public void BaseMethod()
        {
            Console.WriteLine("Bazna metoda pozvana od {0}", GetType());
        }
    }
}
