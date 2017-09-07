using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InitializingMultiDimensionalArray
{
    class Program
    {
        static void Main()
        {
            const int rows = 4;
            const int columns = 3;

            //zakljucuje da je rijec o polju 4x3;
            int[,] rectangularArray =
            {
                {0, 1, 2}, {3, 4, 5}, {6, 7, 8}, {9, 10, 11}
            };

            //ispisuje sadrzaj polja
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("rectangularArray[{0},{1}] = {2}", i, j, rectangularArray[i, j]);
                }
            }
        }
    }
}
