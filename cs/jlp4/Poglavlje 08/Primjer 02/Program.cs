using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtendAndCombineInteface
{
    class Program
    {
        static void Main()
        {
            //pravi objekat dokumenta
            Document doc = new Document("Test document");

            //pretvara dokument za razlicita sucelja
            IStorable isDoc = doc as IStorable;
            if (isDoc != null)
            {
                isDoc.Read();
            }
            else
                Console.WriteLine("IStorable not supported");

            ICompressible icDoc = doc as ICompressible;
            if (icDoc != null)
            {
                icDoc.Compress();
            }
            else
                Console.WriteLine("Compressible not supported");

            ILoggedCompressible ilcDoc = doc as ILoggedCompressible;
            if (ilcDoc != null)
            {
                ilcDoc.LogSavedBytes();
                ilcDoc.Compress();
                //ilcDoc.Read(); //ne moze pozvati metodu read
            }
            else
                Console.WriteLine("LoggedCompressible not supported");

            IStorableCompressible isc = doc as IStorableCompressible;
            if (isc != null)
            {
                isc.LogOriginalSize();  //IStorableCompressible
                isc.LogSavedBytes();    //ILoggedCompressible
                isc.Compress();         //ICompressible
                isc.Read();             //IStorable
            }
            else
                Console.WriteLine("StorableCompressible not supported");

            IEncryptable ie = doc as IEncryptable;
            if (ie != null)
            {
                ie.Encrypt();
            }
            else
                Console.WriteLine("Encrytable not supported");
        }
    }
}
