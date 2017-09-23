using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;


namespace Primjer_05
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpChannel chan = new HttpChannel();
            ChannelServices.RegisterChannel(chan, true);

            CalculatorServerNS.CalculatorServer calculator = new CalculatorServerNS.CalculatorServer();
            RemotingServices.Marshal(calculator, "theEndPoint");

            //Posluzij i one koji stoje i cekaju (Milton)
            Console.WriteLine("Press [enter] to exist...");
            Console.ReadKey();
        }
    }
}
