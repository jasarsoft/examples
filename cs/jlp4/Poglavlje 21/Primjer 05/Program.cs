using System;
using System.IO;
using System.Diagnostics;

namespace Primjer_05
{
    class Program
    {
        const int sizeBuff = 1024;

        static void Main()
        {
            Program p = new Program();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            p.Run();

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds.ToString() + " ms");
        }

        //pokrece je sa imenom mape
        private void Run()
        {
            //stvara binarne tokove
            Stream inputStream = File.OpenRead(@"D:\Games\Shollym Multi-Patch 2016\sound.pack");
            Stream outputStream = File.OpenWrite(@"D:\Games\Shollym Multi-Patch 2016\sound.pack.bak");

            //dodaje tokove s medjuspremicima na pocetak binarnih tokova
            BufferedStream bufferedInput = new BufferedStream(inputStream);
            BufferedStream bufferedOutput = new BufferedStream(outputStream);

            int bytesRead;
            byte[] buffer = new byte[sizeBuff];

            while ((bytesRead = bufferedInput.Read(buffer, 0, sizeBuff)) > 0)
            {
                bufferedOutput.Write(buffer, 0, bytesRead);
            }

            bufferedOutput.Flush();
            bufferedInput.Close();
            bufferedOutput.Close();
        }
    }
}
