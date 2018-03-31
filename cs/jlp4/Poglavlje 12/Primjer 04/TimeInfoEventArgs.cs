using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventKeyword
{
    //klasa za cuvanje informacija o dogadjaju
    //u ovom ce slucaju cuvati samo informacije
    //dostupne u klasi clock ali moze cuvati i 
    //dodatne informacije o stanju
    public class TimeInfoEventArgs : EventArgs
    {
        public readonly int hour;
        public readonly int minute;
        public readonly int second;

        public TimeInfoEventArgs(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
    }
}
