using System;

namespace Primjer10
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            string s = "HAL";

            while(i++ < s.Length)
            {
                Console.Write((char)(s[i-1] + 1));
            }
        }
    }
}
