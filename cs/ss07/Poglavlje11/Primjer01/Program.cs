using System;

namespace Primjer01
{
    class Program
    {
        [Obsolete("Metoda FCPlusPlus je zastarjela, koristite FCSharp", false)]
        static void FCPlusPlus()
        {
            //int *arr = (int *) malloc(100 * sizeof(int));
        }

        static void FCSharp()
        {
            int[] arr = new int[100];
        }

        static void Main()
        {
            FCPlusPlus();
        }
    }
}
