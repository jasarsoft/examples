using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverridingInteface
{
    class Program
    {
        static void Main()
        {
            //stvara referencu dokumenta do objekta Note
            Document theNote = new Note("Test Note");
            IStorable isNote = theNote as IStorable;
            if(isNote != null)
            {
                isNote.Read();
                isNote.Write();
            }
            Console.WriteLine();

            //izravan poziv metoda
            theNote.Read();
            theNote.Write();
            Console.WriteLine();

            //pravi objekat note
            Note note2 = new Note("Second Note");
            IStorable isNote2 = note2 as IStorable;
            if(isNote2 != null)
            {
                isNote2.Read();
                isNote2.Write();
            }
            Console.WriteLine();

            //izravno poziva metode
            note2.Read();
            note2.Write();
        }
    }
}
