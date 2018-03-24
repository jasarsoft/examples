using System;
using System.Collections;

namespace Primjer04
{
    class Program
    {
        static void Main()
        {
            ArrayList arr = new ArrayList();

            for (int i = 0; i < 7; i++)
                arr.Add(i);

            for (int i = 0; i < 7; i++)
                arr.Add(0);

            for (int i = 0; i < 14; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
