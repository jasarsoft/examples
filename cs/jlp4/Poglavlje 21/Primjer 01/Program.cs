﻿using System;
using System.IO;

namespace RecursingDirectories
{
    class Program
    {
        //staticke varijable clanise za pracenje ukupnih vrijednosti razina uvlacenja
        static int dirCounter = 1; 
        static int indentLevel = -1; //provi pomak je 0

        static void Main()
        {
            Program p = new Program();

            //odabir pocetne podmape
            string theDirectory = Environment.GetEnvironmentVariable("SystemRoot");
            //korisnici Monoa i Shared source CLI-ja pod Linixom, Unixom ili MacOS X-om
            //predhodna dva reda trebaju staviti u komentar i izdvojiti iz komentara sljedece
            //string theDirectory = "/tmp";

            //poziva metodu za ispitivanje mape, prikazivanje datuma pristupanja i svih podmapa.
            DirectoryInfo dir = new DirectoryInfo(theDirectory);

            p.ExploreDirectory(dir);

            //kompletirano, ispisuje statistike
            Console.WriteLine("\n{0} directories found.", dirCounter);
        }

        //pokrece ju sa DirectoryInfo objektom
        //za svaku mapu koju pronadje rekurzivno ce se pozvati
        private void ExploreDirectory(DirectoryInfo dir)
        {
            indentLevel++; //pomak razine mape

            //stvar uvlake za mape
            for (int i = 0; i < indentLevel; i++)
                Console.Write("  "); //dva razmaka po razini

            //ispisuje mapu i vrijeme kad joj je zadnji put pristupano
            Console.WriteLine("[{0}] {1} [{2}]", indentLevel, dir.Name, dir.LastAccessTime);

            //uzima sve mape iz tekuce mape i rekurzivno poziva ovu metodu za svaku
            DirectoryInfo[] directories = dir.GetDirectories();
            foreach (DirectoryInfo newDir in directories)
            {
                dirCounter++; //povrecava brojac
                ExploreDirectory(newDir);
            }
            indentLevel--;
        }
    }
}
