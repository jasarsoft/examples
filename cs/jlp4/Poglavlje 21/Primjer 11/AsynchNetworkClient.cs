using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace AsynchNetworkClientNM
{
    class AsynchNetworkClient
    {
        private NetworkStream streamToServer;

        public AsynchNetworkClient()
        {
            string serverName = "localhost";
            Console.WriteLine("Connecting to {0}", serverName);
            TcpClient tcpSocket = new TcpClient(serverName, 65000);
            streamToServer = tcpSocket.GetStream();
        }

        public int Run()
        {
            string message = "Hello Programming C#";
            Console.WriteLine("Sending {0} to server.", message);

            //stvara streamWriter i koristi ga za zapisivanje niza na poluzitelju
            StreamWriter writer = new StreamWriter(streamToServer);
            writer.WriteLine(message);
            writer.Flush();

            StreamReader reader = new StreamReader(streamToServer);
            string strResponse = reader.ReadLine();
            Console.WriteLine("Recieved: {0}", strResponse);
            streamToServer.Close();
            return 0;
        }
    }
}
