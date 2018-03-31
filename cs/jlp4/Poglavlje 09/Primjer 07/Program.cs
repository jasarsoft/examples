using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SettingArrayBounds
{
    class Program
    {
        public static void CreateArrayWithBounds()
        {
            //pravi i inicijalizira visedimenzionalno polje tipa string;
            int[] lenghtArray = new int[2] { 3, 5 }; //velicina svake dimenzije u polju
            int[] boundsArray = new int[2] { 2, 3 }; //donja granica 

            Array multiDimenzionalArray = Array.CreateInstance(typeof(String), lenghtArray, boundsArray);

            //prikazuje donju i gornju granicu svake dimenzije
            Console.WriteLine("Bounds:\tLower\tUpper");
            for(int i = 0; i < multiDimenzionalArray.Rank; i++)
            {
                Console.WriteLine("{0}:\t{1}\t{2}", 
                    i, multiDimenzionalArray.GetLowerBound(i), multiDimenzionalArray.GetUpperBound(i));
            }
        }

        static void Main()
        {
            Program.CreateArrayWithBounds();
        }
    }
}
