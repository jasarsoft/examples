using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primjer_Dispose
{
    class Testing : IDisposable
    {
        bool is_disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if(!is_disposed)//odlaze samo jednom

            {
                if(disposing)
                {
                    Console.WriteLine("Not in descructor, OK to reference other object");
                }
                //izvodi ciscenje za ovja objekat
                Console.WriteLine("Disposing...");
            }

            this.is_disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            //govori sakupljacu otpada da ne finalizira
            GC.SuppressFinalize(this);
        }

        ~Testing()
        {
            Dispose(false);
            Console.WriteLine("In desctructor.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            using (Testing t = new Testing())
            {

            }
            Console.WriteLine("Main");
        }
    }
}
