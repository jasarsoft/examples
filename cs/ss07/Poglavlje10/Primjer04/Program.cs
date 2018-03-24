using System;

namespace Primjer04
{
    class Program
    {
        static void Main()
        {
            try
            {
                Overflow();
            }
            catch (Exception e)
            {
                Console.WriteLine("Dodatana obrada iznimke...");
            }
        }

        static void Overflow()
        {
            int[] arr = new int[10];

            try
            {
                arr[10] = 1;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Obrada iznimke...");
                throw;
            }
        }
    }
}
