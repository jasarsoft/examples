﻿using System;
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

        public Time(int Year, int Month, int Date, int Hour, int Minute, int Second)
        {
            this.Year = Year;
            this.Month = Month;
            this.Date = Date;
            this.Hour = Hour;
            this.Minute = Minute;
            this.Second = Second;
        }
    }

    class Tester
    {
        static void Main()
        {
            System.DateTime currentTime = System.DateTime.Now;

            Time t1 = new Time(currentTime);
            t1.DisplayCurrentTime();

            Time t2 = new Time(2005, 11, 18, 11, 03, 30);
            t2.DisplayCurrentTime();
        }
    }
}
