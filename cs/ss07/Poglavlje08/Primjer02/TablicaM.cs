using System;

namespace Primjer02
{
    class TablicaM
    {
        private int[,] tab;
        private int dimX, dimY;

        public TablicaM(int x, int y)
        {
            dimX = x;
            dimY = y;
            tab = new int[x, y];

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    tab[i, j] = (i + 1) * (j + 1);
        }

        public int Pomnozi(int x, int y)
        {
            if (x >= 1 && x <= dimX && y >= 1 && y <= dimY)
                return tab[x - 1, y - 1];
            else
                return 0;
        }
    }
}
