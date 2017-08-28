using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primjer_01
{
    public class Time
    {
        //privatne varijable
        int Year;
        int Month;
        int Date;
        int Hour;
        int Minute;
        int Second;

        //javne metode
        public void DisplayCurrentTime()
        {
            Console.WriteLine("stub for DisplayCurrentTime");
        }
    }

    public class Tester
    {
        static void Main()
        {
            Time t = new Time();
            t.DisplayCurrentTime();
        }
    }
}
