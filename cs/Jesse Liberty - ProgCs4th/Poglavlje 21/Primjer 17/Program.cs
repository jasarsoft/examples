using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using System.Text;

namespace Primjer_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Program app = new Program();

            app.Run();
        }

        private void Run()
        {
            //stvara tok konfiguracijske datoteke
            IsolatedStorageFileStream configFile = new IsolatedStorageFileStream("tester.cfg", FileMode.Create);

            //stvar pisac koji ce pisati u toku
            StreamWriter writer = new StreamWriter(configFile);
            //upisuje podatke u konfiguracijsku datoteku
            string output;
            System.DateTime currentTime = System.DateTime.Now;
            output = "Last access: " + currentTime.ToString();
            writer.WriteLine(output);
            output = "Last position = 27, 35";
            writer.WriteLine(output);

            //prazni medjupreznik i posprema
            writer.Close();
            configFile.Close();
        }
    }
}
