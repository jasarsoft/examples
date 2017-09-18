using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangularArray
{
    class Program
    {
        static void Main()
        {
            const int rows = 4;
            const int columns = 3;

            //deklarira cjelobrojno poslje 4x3
            int[,] rectangularArray = new int[rows, columns];

            //ispunjava polje
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    rectangularArray[i, j] = i + j;
                }
            }

            //ispisuje sadrzaj polja
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.WriteLine("rectangularArray[{0},{1}] = {2}", i, j, rectangularArray[i, j]);
                }
            }
        }
    }
}
