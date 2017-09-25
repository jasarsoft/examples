using System;
using System.IO;

namespace CreatingSubdirectoryManipulationFile
{
    class Tester
    {
        static void Main()
        {
            //stvara instancu i pokrece je
            Tester t = new Tester();

            string theDirectory = @".\Media";
            DirectoryInfo dir = new DirectoryInfo(theDirectory);
            t.ExploreDirectory(dir);
        }

        //pokrece je sa imenom mape
        private void ExploreDirectory(DirectoryInfo dir)
        {
            //stvara novu pod mapu
            string newDirectory = "newTest";
            DirectoryInfo newSubDir = dir.CreateSubdirectory(newDirectory);

            //uzima sve datoteke iz mape i kopira ih u novu mapu
            FileInfo[] filesInDir = dir.GetFiles();
            foreach (FileInfo file in filesInDir)
            {
                string fullName = newSubDir.FullName + "\\" + file.Name;
                file.CopyTo(fullName);
                Console.WriteLine("{0} copied to newTest", file.FullName);
            }

            //uzima kolekciju kopiranih datoteka
            filesInDir = newSubDir.GetFiles();

            //neke brise u nekima mjenja imena
            int counter = 0;
            foreach (FileInfo file in filesInDir)
            {
                string fullName = file.FullName;
                if(counter++ % 2 == 0)
                {
                    file.MoveTo(fullName + ".bak");
                    Console.WriteLine("{0} renamed to {1}", fullName, file.FullName);
                }
                else
                {
                    file.Delete();
                    Console.WriteLine("{0} deleted.", fullName);
                }
            }

            newSubDir.Delete(true); //brise pod mapu
        }
    }
}
