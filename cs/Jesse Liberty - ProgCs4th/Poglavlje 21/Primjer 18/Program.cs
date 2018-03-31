using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using System.Text;


namespace Primjer_18
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
            //otvara tok konfiguracijske datoteke
            IsolatedStorageFileStream configFile = new IsolatedStorageFileStream("tester.cfg", FileMode.Open);

            //stvar standardni citac toka
            StreamReader reader = new StreamReader(configFile);

            //cita datoteku i prikazuje
            string theEntry;
            do
            {
                theEntry = reader.ReadLine();
                Console.WriteLine(theEntry);
            } while (theEntry != null);

            reader.Close();
            configFile.Close();
        }
    }
}
