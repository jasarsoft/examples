using System;

namespace Primjer20
{
    class Program
    {
        static void Main()
        {
            int i, j = 0;
            bool flag = false;

            for(i = 0; i < 100 && !flag; i++)
            {
                for(j = 0; j < 100; j++)
                {
                    if(i + j == 10)
                    {
                        flag = true;
                        break;
                    }
                }
            }

            //i ce biti povecan nakon break, pa ga treba samnjiti za 1
            Console.WriteLine("{0} {1}", --i, j);
        }
    }
}
