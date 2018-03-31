using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventsWithDelegates
{
    //promatrac
    //DisplayClock se pretplacuje na dogadjaj sata
    //posao DisplyClock je da prikazuje trenutno vrijeme
    public class DisplayClock
    {
        //pretplacuje se na dogadjaj SecondChangeHandler sata
        public void Subscribe(Clock theClock)
        {
            theClock.OnSecondChange += new Clock.SecondChangeHandler(TimeHasChanged);
        }

        //metoda koja implementira delegiranu funkcionalnost
        public void TimeHasChanged(object theClock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("Current time: {0}:{1}:{2}", ti.hour.ToString(), ti.minute.ToString(), ti.second.ToString());
        }
    }
}
