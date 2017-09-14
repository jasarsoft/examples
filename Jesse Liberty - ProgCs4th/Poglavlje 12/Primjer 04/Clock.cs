using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EventKeyword
{
    //nas subjekt - to je klasa koje ce druge klase promatrati
    //klasa objavljuje jednog delegata: OnSecondChange
    //promatraci se pretplacuju na taj dogadjaj
    public class Clock
    {
        private int hour;
        private int minute;
        private int second;

        //delegat kojeg pretplatnici moraju implementirati
        public delegate void SecondChangeHandler(object clock, TimeInfoEventArgs timeInformation);

        //kljucna rijec event nadzire pristup delegatu
        public event SecondChangeHandler OnSecondChange;

        //pokrece sat; objavit ce dogadjaj sa svaku sekundu
        public void Run()
        {
            for(;;)
            {
                //spava 10 milisekundi
                Thread.Sleep(10);

                //uzima trenuto vrijeme
                System.DateTime dt = System.DateTime.Now;

                //ako se sekunda promjenila obavjestava pretplanike
                if(dt.Second != second)
                {
                    //stvara objakat TimeInfoEventArgs za prosljedivanje pretplaniku
                    TimeInfoEventArgs timeInformation = new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);

                    //ako se neko pretplatio obavjestava pretplanike
                    if(OnSecondChange != null)
                    {
                        OnSecondChange(this, timeInformation);
                    }

                    //azurira stanje
                    this.second = dt.Second;
                    this.minute = dt.Minute;
                    this.hour = dt.Hour;
                }
            }
        }
    }
}
