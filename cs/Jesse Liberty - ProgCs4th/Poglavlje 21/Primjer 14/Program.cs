using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Text;

namespace Primjer_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //stvara WebRequest za odredjenu stranicu
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://jesseliberty.com/");

            //salje web zahtjev za WebResponse koji ucahurava tu stranicu
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();

            //uzima stream reader od oggovora
            StreamReader streamReader = new StreamReader(webResponse.GetResponseStream(), Encoding.ASCII);

            try
            {
                string outputString;
                outputString = streamReader.ReadToEnd();
                Console.WriteLine(outputString);
            }
            catch
            {
                Console.WriteLine("Exception reading from Web page");
            }

            streamReader.Close();
        }
    }
}
