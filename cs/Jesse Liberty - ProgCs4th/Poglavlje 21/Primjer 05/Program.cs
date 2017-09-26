﻿using System;
using System.IO;

namespace Primjer_05
{
    class Program
    {
        const int sizeBuff = 1024;

        static void Main()
        {

        }

        //pokrece je sa imenom mape
        private void Run()
        {
            //stvara binarne tokove
            Stream inputStream = File.OpenRead(@"input.txt");
            Stream outputStream = File.OpenWrite(@"output.txt.bak");

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
