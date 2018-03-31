using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Primjer_13
{
    class AsynchNetworkClient
    {
        private NetworkStream streamToServer;
        private const int BufferSize = 256;

        public AsynchNetworkClient()
        {
            string serverName = "127.0.0.1";
            Console.WriteLine("Connecting to {0}", serverName);
            TcpClient tcpSocket = new TcpClient(serverName, 65000);
            streamToServer = tcpSocket.GetStream();
        }

        public int Run()
        {
            string message = @"input.txt";
            Console.WriteLine("Sending {0} to server.", message);

            //stvara streamWriter i koristi ga za zapisivanje niza na poluzitelju
            StreamWriter writer = new StreamWriter(streamToServer);
            writer.WriteLine(message);
            writer.Flush();

            bool fQuit = false;

            //dok podaci stizu sa posluzitelja nastavlja citati
            while(!fQuit)
            {
                //medjuspremink za cuvanje odgovora
                char[] buffer = new char[BufferSize];
                //odgovor citanja
                StreamReader reader = new StreamReader(streamToServer);
                //provjera koliko je bajtova smjesteno u medjuspremink
                int bytesRead = reader.Read(buffer, 0, BufferSize);
                if (bytesRead == 0) //ni jedan, izlaz
                    fQuit = true;
                else                //imas neki
                {
                    //prikazuje ga kao niz
                    string theString = new string(buffer);
                    Console.WriteLine(theString);
                }
            }

            streamToServer.Close();
            return 0;
        }
    }
}
