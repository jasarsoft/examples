using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace Primjer_10
{
    class Program
    {
        //deklarira WinApi metodu koju zelite koristiti u P/Invoke
        [DllImport("karnel32.dll", EntryPoint = "MoveFile", ExactSpelling = false,
                    CharSet = CharSet.Unicode, SetLastError = true)]
        static extern bool MoveFile(string sourceFile, string destinationFile);


        static void Main()
        {
            //stvar instancu i pokrece je
            Program p = new Program();
            string theDirectory = @".\test";
            DirectoryInfo dir = new DirectoryInfo(theDirectory);
            p.ExploreDirectory(dir);
        }

        //pokrece je s imenom mape
        private void ExploreDirectory(DirectoryInfo dir)
        {
            //pravi novu mapu
            string newDirectory = "newTest";
            DirectoryInfo newSubDir = new DirectoryInfo(newDirectory);

            //uzima sve datoteke u mapi i kopira ih u novu mapu
            FileInfo[] filesInDir = dir.GetFiles();
            foreach(FileInfo file in filesInDir)
            {
                string fullName = newSubDir.FullName + "\\" + file.Name;
                file.CopyTo(fullName);
                Console.WriteLine("{0} copied to newTest", file.FullName);
            }

            //uzima kolekcija kopiranih datoteka
            filesInDir = newSubDir.GetFiles();

            //neke brise a ostalima mjenja imena
            int counter = 0;
            foreach(FileInfo file in filesInDir)
            {
                string fullName = file.FullName;
                if(counter++ % 2 == 0)
                {
                    //P/Invoke Windows API
                    Program.MoveFile(fullName, fullName + ".bak");
                    Console.WriteLine("{0} renamed to {1}", fullName, file.FullName);
                }
                else
                {
                    file.Delete();
                    Console.WriteLine("{0} deleted.", fullName);
                }

                //brise pod mapu
                newSubDir.Delete(true);
            }
        }
    }
}
