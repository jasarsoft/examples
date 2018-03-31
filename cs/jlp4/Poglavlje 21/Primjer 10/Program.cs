using System;
using System.Net;
using System.Net.Sockets;

namespace AsynchNetworkServer
{
    class Program
    {
        static void Main()
        {
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
                Console.WriteLine("Client connected");
                ClientHandler handler = new ClientHandler(socketForClient);
                handler.StartRead();
            }
        }
    }
}
