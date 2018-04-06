using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UsingPointers
{
    class Program
    {
        static void Main()
        {
            //stvara instancu APIFileReader
            //i prosljedjuje ime postojece datoteke
            APIFileReader fileReader = new APIFileReader("myTestFile.txt");

            //stvara medjuspremink i ASCII koder
            const int bufferSize = 128;
            byte[] buffer = new byte[bufferSize];
            ASCIIEncoding asciiEncoder = new ASCIIEncoding();

            //ucitava datoteku u medjuspremik i prikazjue na konzolu
            while(fileReader.Read(buffer, 0, bufferSize) != 0)
            {
                Console.WriteLine("{0}", asciiEncoder.GetString(buffer));
            }
        }
    }
}
