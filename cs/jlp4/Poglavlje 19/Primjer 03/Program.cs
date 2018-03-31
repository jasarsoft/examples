using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace CalculatorServerNS
{
    class Program
    {
        static void Main(string[] args)
        {
            //stvara kanal i registrira ga
            HttpChannel chan = new HttpChannel(65100);
            ChannelServices.RegisterChannel(chan, false);

            Type calcType = Type.GetType("CalculatorServerNS.CalculatorServer");

            //registrira tip dobro poznatog objekta i govori posluzitelju
            //da poveze tip sa zavrsom tackom "theEndPoint"
            //RemotingConfiguration.RegisterWellKnownServiceType(calcType, "theEndPoint", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(calcType, "theEndPoint", WellKnownObjectMode.SingleCall);

            Console.WriteLine("Press [ENTER] to exit...");
            Console.ReadKey();
        }
    }
}
