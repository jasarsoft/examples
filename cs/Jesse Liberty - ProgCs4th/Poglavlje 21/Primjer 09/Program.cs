using System;
using System.IO;
using System.Net.Sockets;

namespace Client
{
    class Program
    {
        static void Main()
        {
            //stvara TcpClient za komunikaciju s poslužiteljem
            TcpClient socketForServer;

            try
            {
                socketForServer = new TcpClient("localhost", 65000);
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to connect to server at {0}:65000", "localhost");
                return;
            }

            //stvara NetworkStream StreamReader objekte
            NetworkStream networkStream = socketForServer.GetStream();
            System.IO.StreamReader streamReader = new StreamReader(networkStream);

            try
            {
                string outputString;

                //cita podatke od domacina i prikazuje ih
                do
                {
                    outputString = streamReader.ReadLine();
                    if(outputString != null)
                    {
                        Console.WriteLine(outputString);
                    }
                } while (outputString != null);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception reading form server");
            }

            networkStream.Close();
        }
    }
}
