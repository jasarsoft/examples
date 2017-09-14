using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EventsWithDelegates
{
    class Program
    {
        static void Main()
        {
            //pravi novi sata
            Clock theClock = new Clock();

            //pravi prikaz i govori mu da se pretplati na upravo otvoren sat
            DisplayClock dc = new DisplayClock();
            dc.Subscribe(theClock);

            //pravi log objekat i govori mu da se pretplati na sat
            LogCurrentTime lct = new LogCurrentTime();
            lct.Subscribe(theClock);

            //pokrece sat
            theClock.Run();
        }
    }
}
