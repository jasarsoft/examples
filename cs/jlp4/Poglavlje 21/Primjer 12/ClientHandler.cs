using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace AsynchNetworkServerFileServer
{
    class ClientHandler
    {
        private const int BufferSize = 256;
        private byte[] buffer;
        private Socket socket;
        private Stream inputStream;
        private NetworkStream networkStream;
        private AsyncCallback callbackRead;
        private AsyncCallback callbackWrite;
        private AsyncCallback myFileCallBack;

        public ClientHandler(Socket socketForClient)
        {
            socket = socketForClient; //incjaliziranje varijable clanice
            buffer = new byte[256]; //incjalizovanje medjuspremnika za cuvanje datoteka
            networkStream = new NetworkStream(socketForClient); //stvaranje mreznog toka
            myFileCallBack = new AsyncCallback(this.OnFileCompletedRead); //postavlja povratni poziv datoteke za citanje
            callbackRead = new AsyncCallback(this.OnReadComplete); //postavlja povratni poziv za citanje iz mreznog toka
            callbackWrite = new AsyncCallback(this.OnWriteComplete);  //postavlja povratni poziv za pisanje u mrezni tok
        }

        //zapocinje citanje niza od klijenta
        public void StartRead()
        {
            //cita sa mreze i uzima ime datoteke
            networkStream.BeginRead(buffer, 0, buffer.Length, callbackRead, null);
        }

        //kada je pozvan natrag tijekom citanja prikazuje niz vraca ga natrag klijentu
        private void OnReadComplete(IAsyncResult ar)
        {
            int bytesRead = networkStream.EndRead(ar);
            if(bytesRead > 0) //ako dobije niz
            {
                //pretvara ga u ime datoteke
                string fileName = System.Text.Encoding.ASCII.GetString(buffer, 0, bytesRead);
                //osjvezava konzolu
                Console.Write("Recieved {0} bytes form clinet: {1}", bytesRead, fileName);
                //otvara ulazni tok datoteke
                inputStream = File.OpenRead(fileName);
                //zapocinje citanje datoteke
                inputStream.BeginRead(
                    buffer,         //cuva rezultat
                    0,              //pomak
                    buffer.Length,  //velicina medjuspreminka
                    myFileCallBack, //delegat povratnog poziva
                    null);
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

        //kad imate pun medjuspremik datoteke
        void OnFileCompletedRead(IAsyncResult ar)
        {
            int bytesRead = inputStream.EndRead(ar);
            //ako je ucitan dio datoeke
            if(bytesRead > 0)
            {
                //ispisuje ga klijentu
                networkStream.BeginWrite(buffer, 0, bytesRead, callbackWrite, null);
            }
            else
            {
                Console.WriteLine("Finished.");
                networkStream.Close();
                socket.Close();
                networkStream = null;
                socket = null;
            }
        }

        //nakon upisivanja niza uzima drugi dio datoteke
        private void OnWriteComplete(IAsyncResult ar)
        {
            networkStream.EndWrite(ar);
            Console.WriteLine("Write complete");
            //zapocinje ucitavanje ostatke datoteke
            networkStream.BeginRead(
                buffer,         //cuva rezultate
                0,              //pomak
                buffer.Length,  //buffersize
                myFileCallBack, //delegat povratnog poziva
                null);          //lokalni objekt stanja
        }
    }
}
