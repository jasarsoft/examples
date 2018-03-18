using System;


namespace Primjer03
{
    class Program
    {
        private short xCoord;
        private static short yCoord;

        private void FCoord()
        {
            xCoord = 300;
            yCoord = 400;
        }

        static void Main()
        {
            Program tmp = new Program();
            tmp.xCoord = 100;               //ok
            //tmp.yCoord = 200;               //greska

            //Program.xCoord = 100;           //greska
            Program.yCoord = 100;           //ok

            //FCoord();                       //greska
        }
    }
}
