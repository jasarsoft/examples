using System;
using System.IO;

namespace ReadingWritingToTextFile
{
    class Program
    {
        static void Main()
        {
            //otvara datoteku
            FileInfo theSourceFile = new FileInfo(@"input.txt");

            //stvara citac teksta za tu datoteku
            StreamReader reader = theSourceFile.OpenText();

            //stvara pisac teksta za novu datoteku
            StreamWriter writer = new StreamWriter(@"output.txt", false);

            //stvara tekstualnu varijablu za cuvanje svakog reda
            string text;

            //prolazi kroz datoteku cita svaki red i upisuje ih u datoteku
            do
            {
                text = reader.ReadLine();
                writer.WriteLine(text);
                Console.WriteLine(text);
            } while (text != null);

            //spremanje i zatvaranje
            reader.Close();
            writer.Close();
        }
    }
}
