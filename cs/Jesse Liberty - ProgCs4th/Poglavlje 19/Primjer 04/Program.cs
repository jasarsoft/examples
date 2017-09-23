using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace CalculatorClient
{
    class Program
    {
        static void Main()
        {
            int[] myIntArray = new int[3];

            Console.WriteLine("Watson come here I need you...");

            //stvara http kanal i registrira ga
            //koristi ulaz 0
            HttpChannel chan = new HttpChannel(0);
            ChannelServices.RegisterChannel(chan, false);

            Object obj = RemotingServices.Connect(typeof(Calculator.ICalc), "http://localhost:65100/theEndPoint");

            try
            {
                //pretvara objekat u sucelje
                Calculator.ICalc calc = obj as Calculator.ICalc;

                //koristi sucelje za pozivanje metoda
                double sum = calc.Add(3.0, 4.0);
                double difference = calc.Sub(3, 4);
                double product = calc.Mult(3, 4);
                double quotient = calc.Div(3, 4);

                //ispisuje rezultate
                Console.WriteLine("3 + 4 = {0}", sum);
                Console.WriteLine("3 - 4 = {0}", difference);
                Console.WriteLine("3 * 4 = {0}", product);
                Console.WriteLine("3 / 4 = {0}", quotient);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: {0}", ex.Message);
            }
        }
    }
}
