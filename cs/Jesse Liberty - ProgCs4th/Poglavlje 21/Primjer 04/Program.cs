using System;
using System.IO;
using System.Diagnostics;

namespace ImplementingBinaryReadWriteToFile
{
    class Program
    {
        const int sizeBuff = 1024;

        static void Main()
        {
            //stvara instancu i pokrece je
            Program p = new Program();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            p.Run();

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds.ToString() + " ms");
        }

        //pokretanje sa imenom mape
        private void Run()
        {
            //datoteka za citanje
            Stream inputStream = File.OpenRead(@"D:\Games\Shollym Multi-Patch 2016\sound.pack");
            //datoteka za upisivanje
            Stream outputStrem = File.OpenWrite(@"D:\Games\Shollym Multi-Patch 2016\sound4.pack.bak");
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
