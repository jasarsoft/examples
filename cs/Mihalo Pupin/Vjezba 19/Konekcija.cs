using System;
using System.Timers;

namespace Vjezba_19
{
    public delegate void MessageHandler(string messageText);

    class Konekcija
    {
        public event MessageHandler MessageArrived;

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
                MessageArrived(" #### Pozdrav ####");
        }
    }
}
