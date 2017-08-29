using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VaryingReturnType
{
    class Tester
    {
        private int Triple(int val)
        {
            return 3 * val;
        }

        private long Triple(long val)
        {
            return 3 * val;
        }

        public void Test()
        {
            int x = 5;
            int y = Triple(x);
            Console.WriteLine("x: {0}  y: {1}", x, y);

            long lx = 10;
            long ly = Triple(lx);
            Console.WriteLine("lx:{0} y:{1}", lx, ly);
        }

        static void Main()
        {
            Tester t = new Tester();
            t.Test();
        }
    }
}
