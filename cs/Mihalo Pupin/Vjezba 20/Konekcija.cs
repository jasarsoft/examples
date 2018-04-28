using System;
using System.Timers;

namespace Vjezba_20
{
    public delegate void MessageHandler(Konekcija source, MessageArrivedEventArgs e);

    public class Konekcija
    {
        public event MessageHandler MessageArrived;

        private string naziv;

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        private Timer pollTimer;

        public Konekcija()
        {
            pollTimer = new Timer(100);
            pollTimer.Elapsed += new ElapsedEventHandler(ProvjeraPoruke);
        }

        public void Connect()
        {
            pollTimer.Start();
        }

        public void Disconnect()
        {
            pollTimer.Stop();
        }

        private void ProvjeraPoruke(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("PRovjera nove poruke.");
            Random ran = new Random();
            if ((ran.Next(9) == 0) && (MessageArrived != null))
                MessageArrived(this, new MessageArrivedEventArgs("### Pozdrav ####"));
        }
    }
}
