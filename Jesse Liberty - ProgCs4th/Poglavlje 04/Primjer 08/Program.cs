using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverloadConstructor
{
    public class Time
    {
        //privatne varijable clanice
        private int Year;
        private int Month;
        private int Date;
        private int Hour;
        private int Minute;
        private int Second;

        //javne metode za pristupanje
        public void DisplayCurrentTime()
        {
            System.Console.WriteLine("{0}/{1}/{2} {3}:{4}:{5}", Month, Date, Year, Hour, Minute, Second);
        }

        public int GetHour()
        {
            return Hour;
        }

        public void SetTime(int hr, out int min, ref int sec)
        {
            //ako je prosljedjeno vrijeme vece od 30
            //povecava minute i postavlja sekunde  na 0
            //u suprotnom ne mjenja nista
            if(sec >= 30)
            {
                Minute++;
                Second = 0;
            }

            Hour = hr; //postavlja na proslijedjenu vrijednost

            //proslijedjuje minute i sekunde natrag
            min = Minute;
            sec = Second;
        }

        public void GetTime(ref int h, ref int m, ref int s)
        {
            h = Hour;
            m = Minute;
            s = Second;
        }

        //konstruktor
        public Time(System.DateTime dt)
        {
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
            System.DateTime currentTime = System.DateTime.Now;
            Time t = new Time(currentTime);
            t.DisplayCurrentTime();

            int theHour = 3;
            int theMinute;
            int theSecond = 20;

            t.SetTime(theHour, out theMinute, ref theSecond);
            System.Console.WriteLine("The minute is now: {0} and {1} seconds", theMinute, theSecond);

            theSecond = 40;
            t.SetTime(theHour, out theMinute, ref theSecond);
            System.Console.WriteLine("the minute is now: " + "{0} and {1}", theMinute, theSecond);
        }
    }
}
