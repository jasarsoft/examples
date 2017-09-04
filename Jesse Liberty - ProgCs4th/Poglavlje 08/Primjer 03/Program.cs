using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsOperator
{
    class Program
    {
        static void Main()
        {
            //kolekcija Docmunets
            Document[] docArray = new Document[2];

            //prvi unos je Document
            docArray[0] = new Document("Test document");

            //drugi unos je CompressibleDocument
            //uredu je jer je CompressibleDocument Document
            docArray[1] = new CompressibleDocument("Test compressible document");

            //ne znamo sta cemo izvuci iz sesira
            foreach(Document doc in docArray)
            {
                //ispisuje ime
                Console.WriteLine("Got: {0}", doc);

                //obje prolaze test
                //sa operatorom is
                if(doc is IStorable)
                {
                    IStorable isDoc = (IStorable)doc;
                    isDoc.Read();
                }

                //sa operatorom as
                IStorable isDoc2 = doc as IStorable;
                if(isDoc2 != null)
                {
                    isDoc2.Read();
                }

                //ne uspjeva za Documnet
                //prolazi za CompressibleDocument
                if(doc is ICompressible)
                {
                    ICompressible icDoc = (ICompressible)doc;
                    icDoc.Compress();
                }
            }
        }
    }
}
