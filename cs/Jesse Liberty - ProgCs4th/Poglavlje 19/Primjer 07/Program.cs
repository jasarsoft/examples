using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace Primjer_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //stvara kanal i registrira ga
            HttpChannel chan = new HttpChannel(65100);
            ChannelServices.RegisterChannel(chan, false);

            //napravite vlastitu instancu i izravno pozovite Marshal metodu
            CalculatorServer calculator = new CalculatorServer();
            ObjRef objRef = RemotingServices.Marshal(calculator);
            FileStream fileStream = new FileStream("calculatorSoap.txt", FileMode.Create);
            SoapFormatter soapFormater = new SoapFormatter();
            soapFormater.Serialize(fileStream, objRef);
            fileStream.Close();

            //posluzuj i one koji stoje i cekaju
            Console.WriteLine("Exported to CalculatorSoap.txt. Press ENTER to exit...");
            Console.ReadKey();
        }
    }
}
