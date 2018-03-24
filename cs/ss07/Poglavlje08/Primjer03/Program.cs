using System;

namespace Primjer03
{
    class Program
    {
        static void Main()
        {
            sbyte[][] arr = new sbyte[3][];
            arr[0] = new sbyte[7];
            arr[1] = new sbyte[5];
            arr[2] = new sbyte[9];

            sbyte x = 1;
            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr[i].Length; j++)
                    arr[i][j] = x++;

            for (int i = 0; i < arr.Length; i++)
                Array.Reverse(arr[i]);

            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write(arr[i][j] + ", ");
                Console.WriteLine();
            }
        }
    }
}
