using System;
using System.Net;
using System.Net.Sockets;

namespace AsynchNetworkServerFileServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //stvara novi TcpListener i zapocinje slusanje ulaza 65000
            IPAddress localAddress = IPAddress.Parse("127.0.0.1");
            TcpListener tcpListener = new TcpListener(localAddress, 65000);
            tcpListener.Start();

            //nastavlja slusati dok ne posalje datoteku
            for (;;)
            {
                //ako se klijent spoji prihvaca vezu i 
                //vraca novu pristupnu tacku socketForClient
                //dok tcpListener i dalje slusa
                Socket socketForClient = tcpListener.AcceptSocket();
                if(socketForClient.Connected)
                {
                    Console.WriteLine("Client connected");
                    ClientHandler handler = new ClientHandler(socketForClient);
                    handler.StartRead();
                }
            }
        }
    }
}
