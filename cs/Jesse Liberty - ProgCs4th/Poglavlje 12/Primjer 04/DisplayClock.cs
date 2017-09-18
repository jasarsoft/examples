using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventKeyword
{
    //promatrac
    //DisplayClock se pretplacuje na dogadjaj sata
    //posao DisplyClock je da prikazuje trenutno vrijeme
    public class DisplayClock
    {
        //kad ima sat, pretplacuje se na dogadjaj SecondChangeHandler
        public void Subscribe(Clock theClock)
        {
            //theClock.OnSecondChange += new Clock.SecondChangeHandler(TimeHasChanged);
            //theClock.OnSecondChange += TimeHasChanged;
            theClock.OnSecondChange += delegate (object theClock1, TimeInfoEventArgs ti)
            {
                Console.WriteLine("Current time: {0}:{1}:{2}", ti.hour.ToString(), ti.minute.ToString(), ti.second.ToString());
            };
        }

        //metoda koja implementira delegiranu funkcionalnost
        public void TimeHasChanged(object theClock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("Current time: {0}:{1}:{2}", ti.hour.ToString(), ti.minute.ToString(), ti.second.ToString());
        }
    }
}
