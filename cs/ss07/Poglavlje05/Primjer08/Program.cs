using System;

namespace Primjer08
{
    class Program
    {
        static void Main()
        {
            Office[] documents = new Office[3];

            documents[0] = new Word();
            documents[1] = new Excel();
            documents[2] = new Access();

            for (int i = 0; i < 3; i++)
                documents[i].SpremiDatoteku();
        }
    }
}
