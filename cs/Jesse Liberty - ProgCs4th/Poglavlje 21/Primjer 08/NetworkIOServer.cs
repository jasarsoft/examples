using System;
using System.Net;
using System.Net.Sockets;

namespace NetworkStreamingServer
{
    class NetworkIOServer
    {
        static void Main()
        {
            NetworkIOServer app = new NetworkIOServer();
            app.Run();
        }

        private void Run()
        {
            //stvara novi TcpListener i pocinje slusati na ulazu 65000
            IPAddress localAddress = IPAddress.Parse("127.0.0.1");
            TcpListener tcpListener = new TcpListener(localAddress, 65000);
            tcpListener.Start();

            //nastavlja slusati dok ne postavlja datoteku
            for(;;)
            {
                //ako se klijent spoji, prihvaca vezu i vraca novu pristupnu tacku
                //socketForClient dok tcpListener nastavlja slusati
                Socket socketForClient = tcpListener.AcceptSocket();
                Console.WriteLine("Client connected");

                //poziva pomocnu metodu za slanje datoteke
                SendFileToClient(socketForClient);
                Console.WriteLine("Disconneting form client...");

                //cisti i ide kuci
                socketForClient.Close();
                Console.WriteLine("Exiting...");
                break;
            }
        }

        //pomocna metoda za slanje datoteke
        private void SendFileToClient(Socket socketForClient)
        {
            //stvara mrezni tok i pisac toka na tom mreznom toku
            NetworkStream networkStream = new NetworkStream(socketForClient);
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(networkStream);

            //stvara citac toka za datoteku
            System.IO.StreamReader streamReader = new System.IO.StreamReader("input.txt");

            string theString;
            //iterira kroz datoteku i salje klijentu red po red
            do
            {
                theString = streamReader.ReadLine();
                if(theString != null)
                {
                    Console.WriteLine("Sending {0}", theString);
                    streamWriter.WriteLine(theString);
                    streamWriter.Flush();
                }
            } while (theString != null);

            streamReader.Close();
            streamWriter.Close();
            networkStream.Close();
        }
    }
}
