using System;

namespace Primjer06
{
    class Program
    {
        static void Main()
        {
            int flag = 0;
            bool uvijet = false;

            if (uvijet && VeryImportant())
                flag = 1;

        }

        static bool VeryImportant()
        {
            int x = 0;
            //obavljanje vrlo vaznog posla
            return x == 0 ? true : false;
        }
    }
}
