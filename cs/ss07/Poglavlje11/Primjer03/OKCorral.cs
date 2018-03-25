using System;

namespace Primjer03
{
    class OKCorral
    {
        private int numberOfBulles = 100;
        private int numberOfClantons = 4;

        [Autor("Wyatt Earp", 1.0, VrstaPosla = "Testiranje")]
        public void ShotByGun()
        {
            numberOfBulles--;
            if (numberOfBulles % 2 == 0)
                numberOfClantons--;
        }

        [Autor("Doc Holliday", 1.0, VrstaPosla = "Programiranje")]
        public void ShortByColt()
        {
            numberOfBulles--;
            numberOfClantons--;
        }

        [Autor("Wyatt Earp", 2.0)]
        public int NumberOfBullets
        {
            get { return numberOfBulles; }
        }

        [Autor("Wyatt Earp", 2.0)]
        [Autor("Doc Holliday", 2.0 , VrstaPosla = "Programiranje")]
        public int NumberOfClantos
        {
            get { return numberOfClantons; }
        }
    }
}
