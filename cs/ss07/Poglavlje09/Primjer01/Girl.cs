using System;


namespace Primjer01
{
    class Girl
    {
        private int visina;
        private DateTime datumR;

        public Girl(int i , DateTime d)
        {
            visina = i;
            datumR = d;
        }

        public int Visina
        {
            get { return visina; }
        }

        public DateTime DatumR
        {
            get { return datumR; }
        }
    }
}
