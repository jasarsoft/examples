using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticPublicConstants
{
    public class RightNow
    {
        //javne varijable clanice
        public static readonly int Year;
        public static readonly int Month;
        public static readonly int Date;
        public static readonly int Hour;
        public static readonly int Minute;
        public static readonly int Second;

        static RightNow()
        {
            DateTime dt = DateTime.Now;
            Year = dt.Year;
            Month = dt.Month;
            Date = dt.Day;
            Hour = dt.Hour;
            Minute = dt.Minute;
            Second = dt.Second;
        }
    }

    class Tester
    {
        static void Main()
        {
            Console.WriteLine("This year: {0}", RightNow.Year.ToString());
            //RightNow.Year = 2006;
            Console.WriteLine("This year: {0}", RightNow.Year.ToString());
        }
    }
}
