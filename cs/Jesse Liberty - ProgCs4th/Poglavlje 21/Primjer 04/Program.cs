using System;
using System.IO;

namespace ImplementingBinaryReadWriteToFile
{
    class Program
    {
        const int sizeBuff = 1024;

        static void Main()
        {
            //stvara instancu i pokrece je
            Program p = new Program();
            p.Run();
        }

        //pokretanje sa imenom mape
        private void Run()
        {
            //datoteka za citanje
            Stream inputStream = File.OpenRead(@"input.txt");
            //datoteka za upisivanje
            Stream outputStrem = File.OpenWrite(@"output.bak");
            //stvara medjuspremnik zacuvanje bajtova
            byte[] buffer = new byte[sizeBuff];
            int bytesRead;

            //dok metoda vraca bajtove nastavlja ih upisivati u islazni tok
            while((bytesRead = inputStream.Read(buffer, 0, sizeBuff)) > 0)
            {
                outputStrem.Write(buffer, 0, bytesRead);
            }

            //posprema i zatvara fajlove prije zavrsetka
            inputStream.Close();
            outputStrem.Close();
        }
    }
}
