using System;
using System.IO;
using System.Text;

namespace AsynchronousIO
{
    class AsynchIOTester
    {
        private Stream inputStream;

        //delegira metodu
        private AsyncCallback myCallBack;

        //medjuspremnik za pohranu ucitanih podataka
        private byte[] buffer;

        //velicina medjuspremnika
        const int BufferSize = 256;

        //konstruktor
        public AsynchIOTester ()
        {
            //otvara ulazni tok
            inputStream = File.OpenRead(@"input.txt");

            //dodjeljuje medjuspremnik
            buffer = new byte[BufferSize];

            //dodjeljuje povratni poziv
            myCallBack = new AsyncCallback(this.OnCompletedRead);
        }

        //povratna metoda
        void OnCompletedRead(IAsyncResult asyncResult)
        {
            int byteRead = inputStream.EndRead(asyncResult);

            //ako ima bajtove stvara od njih niz i prikazuje ga
            //zatim zapocinje ponovo u suptronom smo gotovi
            if(byteRead > 0)
            {
                String s = Encoding.ASCII.GetString(buffer, 0, byteRead);
                Console.WriteLine(s);
                inputStream.BeginRead(buffer, 0, buffer.Length, myCallBack, null);
            }
        }

        public void Run()
        {
            inputStream.BeginRead(
                buffer,             //cuva rezultate
                0,                  //pomak
                buffer.Length,      //(BufferSize)
                myCallBack,         //delegat povratnog poziva
                null);              //lokalni objekt stanja

            //radi neki posao dok se podaci ucitaju
            for(long i = 0; i < 500000; i++)
            {
                if(i%100 == 0)
                {
                    Console.WriteLine("i: {0}", i);
                }
            }
        }
    }
}
