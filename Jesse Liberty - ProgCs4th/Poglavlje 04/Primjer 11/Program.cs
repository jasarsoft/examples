using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingAProperty
{
    public class Time
    {
        //privatne varijable clanice
        private int year;
        private int month;
        private int date;
        private int hour;
        private int minute;
        private int second;

        //javne metode za pristupanje
        public void DisplayCurrentTime()
        {
            Console.WriteLine("Time\t: {0}/{1}/{2} {3}:{4}:{5}", month, date, year, hour, minute, second);
        }

        //konstruktori
        public Time(DateTime dt)
        {
            year = dt.Year;
            month = dt.Month;
            date = dt.Day;
            hour = dt.Hour;
            minute = dt.Minute;
            second = dt.Second;
        }

        //svojstva
        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                hour = value;
            }
        }
    }

    class Tester
    {
        static void Main()
        {
            DateTime currentTime = DateTime.Now;
            Time t = new Time(currentTime);
            t.DisplayCurrentTime();

            int theHour = t.Hour;
            Console.WriteLine("\nRetrived the hour: {0}\n", theHour);

            theHour++;
            t.Hour = theHour;
            Console.WriteLine("Update the hour: {0}\n", theHour);
        }
    }
}
