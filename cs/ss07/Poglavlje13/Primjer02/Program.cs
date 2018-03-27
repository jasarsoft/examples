using System;
using System.IO;

namespace Primjer02
{
    class Program
    {
        static void Main()
        {
            FilesAndFolders ff = new FilesAndFolders("c:\\");

            ff.OpenDirectory();

            Console.WriteLine();
            Console.WriteLine("{0} datoteka u mapi {1}", ff.MaxFiles, ff.HasMostFiles);
        }
    }
}
