using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba_20
{
    public class MessageArrivedEventArgs : EventArgs
    {
        private string poruka;

        public string Poruka
        {
            get { return poruka; }
        }

        public MessageArrivedEventArgs()
        {
            poruka = "Nijedna poruka nije poslata.";
        }

        public MessageArrivedEventArgs(string novaPoruka)
        {
            poruka = novaPoruka;
        }
    }
}
