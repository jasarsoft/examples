using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleInterface
{
    class Program
    {
        static void Main()
        {
            //pristup metodama u objektu dokument
            Document doc = new Document("Test document");
            doc.Status = 1;
            doc.Read();
            Console.WriteLine("Document status: {0}", doc.Status);
        }
    }
}
