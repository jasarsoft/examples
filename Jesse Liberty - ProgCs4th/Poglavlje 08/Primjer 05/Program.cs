using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExplicitImplementation
{
    class Program
    {
        static void Main()
        {
            //pravi objekt Document-a
            Document theDoc = new Document("Test document");
            IStorable isDoc = theDoc;
            isDoc.Read();

            ITalk itDoc = theDoc;
            itDoc.Read();

            theDoc.Read();
            theDoc.Talk();
        }
    }
}
