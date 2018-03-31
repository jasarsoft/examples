using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primjer_04
{
    public class Time
    {
        //privatne varijable
        int Year;
        int Month;
        int Date;
        int Hour;
        int Minute;
        int Second = 30;//inicijalizator

        //javne metode
        public void DisplayCurrentTime()
        {
            System.DateTime now = System.DateTime.Now;
            Console.WriteLine("Debug: {0}/{1}/{2} {3}:{4}:{5}", now.Month, now.Day, now.Year, now.Hour, now.Minute, now.Second);
            Console.WriteLine("{0}/{1}/{2} {3}:{4}:{5}", Month, Date, Year, Hour, Minute, Second);
        }

        //konstruktori
        public Time(System.DateTime dt)
        {
            Year = dt.Year;
            Month = dt.Month;
            Date = dt.Day;
            Hour = dt.Hour;
            Minute = dt.Minute;
            Second = dt.Second; //eksplicitno pridruzivanje
        }

        public Time(int Year, int Month, int Date, int Hour, int Minute)
        {
            this.Year = Year;
            this.Month = Month;
            this.Date = Date;
            this.Hour = Hour;
            this.Minute = Minute;
        }
    }

    public class Tester
    {
        static void Main()
        {
            System.DateTime currentTime = System.DateTime.Now;
            Time t = new Time(currentTime);
            t.DisplayCurrentTime();

            Time t2 = new Time(2005, 11, 18, 11, 45);
            t2.DisplayCurrentTime();
        }
    }
}
