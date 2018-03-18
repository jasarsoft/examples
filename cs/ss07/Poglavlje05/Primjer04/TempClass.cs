using System;

namespace Primjer04
{
    class TempClass
    {
        private static int counter;

        public TempClass()
        {
            counter++;
        }

        public int BrojInstanci()
        {
            return counter;
        }
    }
}
