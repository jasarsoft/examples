using System;
using System.Net;
using System.Net.Sockets;

namespace AsynchNetworkServer
{
    class ClientHandler
    {
        private byte[] buffer;
        private Socket socket;
        private NetworkStream networkStream;
        private AsyncCallback callbackRead;
        private AsyncCallback callbackWrite;

        public ClientHandler(Socket socketForClient)
        {
            socket = socketForClient;
            buffer = new byte[256];
            networkStream = new NetworkStream(socketForClient);
            callbackRead = new AsyncCallback(this.OnReadComplete);
            callbackWrite = new AsyncCallback(this.OnWriteComplete);
        }

        //zapocinje citanje niza od klijenta
        public void StartRead()
        {
            networkStream.BeginRead(buffer, 0, buffer.Length, callbackRead, null);
        }

        //kada je pozvan natrag tijekom citanja prikazuje niz vraca ga natrag klijentu
        private void OnReadComplete(IAsyncResult ar)
        {
            int bytesRead = networkStream.EndRead(ar);
            if(bytesRead > 0)
            {
                string s = System.Text.Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.Write("Recieved {0} bytes form clinet: {1}", bytesRead, s);
                networkStream.BeginWrite(buffer, 0, bytesRead, callbackWrite, null);
            }
            else
            {
                Console.WriteLine("Read connection dropped");
                networkStream.Close();
                socket.Close();
                networkStream = null;
                socket = null;
            }
        }

        //nakon zapisivanja niza ispisuje poruku i nastavlja sa citanjem
        private void OnWriteComplete(IAsyncResult ar)
        {
            networkStream.EndWrite(ar);
            Console.WriteLine("Write complete");
            networkStream.BeginRead(buffer, 0, buffer.Length, callbackRead, null);
        }
    }
}
