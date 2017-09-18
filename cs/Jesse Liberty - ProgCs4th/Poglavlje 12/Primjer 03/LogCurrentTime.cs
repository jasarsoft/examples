using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventsWithDelegates
{
    //drugi pretplanik ciji je posao zapisivanje u datoteku
    public class LogCurrentTime
    {
        public void Subscribe(Clock theClock)
        {
            theClock.OnSecondChange += new Clock.SecondChangeHandler(WriteLogEntry);
        }

        //ova bih metoda trebala zapisivati u datoteku
        //ispisujemo na konzolu da bismo vidjli efekat
        //ovaj objekat ne cuva stanje
        public void WriteLogEntry(object theClock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("Logging to file: {0}:{1}:{2}", ti.hour.ToString(), ti.minute.ToString(), ti.second.ToString());
        }
    }
}
