using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba_20
{
    class Display
    {
        public void DisplayMessage(Konekcija source, MessageArrivedEventArgs e)
        {
            Console.WriteLine("Poruka koja je stigla: {0}", source.Naziv);
            Console.WriteLine("Tekst poruke: {0}", e.Poruka);
        }
    }
}
