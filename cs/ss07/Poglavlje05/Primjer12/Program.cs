using System;

namespace Primjer12
{
    struct SKoordinate
    {
        public int xCoord, yCoord;

        public SKoordinate(int x, int y)
        {
            xCoord = x;
            yCoord = y;
        }
    }

    class CKoordinate
    {
        public int xCoord, yCoord;

        public CKoordinate(int x, int y)
        {
            xCoord = x;
            yCoord = y;
        }
    }

    class Program
    {
        static void Main()
        {
            SKoordinate s = new SKoordinate(800, 600);
            CKoordinate c = new CKoordinate(1024, 768);

            PromjeniXYs(s);
            PromjeniXYc(c);

            Console.WriteLine("s: " + s.xCoord + ", " + s.yCoord);
            Console.WriteLine("c: " + c.xCoord + ", " + c.yCoord);
        }

        static void PromjeniXYs(SKoordinate sTmp)
        {
            sTmp.xCoord = 100;
            sTmp.yCoord = 200;
        }

        static void PromjeniXYc(CKoordinate cTmp)
        {
            cTmp.xCoord = 100;
            cTmp.yCoord = 200;
        }
    }
}
