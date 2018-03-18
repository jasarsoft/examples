using System;

namespace Primjer10._2
{
    class Program
    {
        static void Main()
        {
            bool flag1 = false, flag2 = false;

            object o = 10;
            long l = 20;

            if (l is object)
                flag1 = true;

            if (o is long)
                flag2 = true;

            Console.WriteLine("flag1 = {0}\nflag2 = {1}", flag1, flag2);
        }
    }
}
