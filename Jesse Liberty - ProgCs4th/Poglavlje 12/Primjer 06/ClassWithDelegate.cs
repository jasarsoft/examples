using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AsyncDelegate
{
    public class ClassWithDelegate
    {
        //viseodredisni delegat koji ucahuruje metodu koja vraca int
        public delegate int DelegateThatReturnsInt();
        public DelegateThatReturnsInt theDelegate;

        public void Run()
        {
            for(;;)
            {
                //spava pola sekunde
                Thread.Sleep(500);

                if(theDelegate != null)
                {
                    //eksplicitno poziva svaku delegiranu metodu
                    foreach(DelegateThatReturnsInt del in theDelegate.GetInvocationList())
                    {
                        //poziva asinhrono i prosljedjuje delegat kao objekat stanja
                        del.BeginInvoke(new AsyncCallback(ResultsReturned), del);
                    }
                }
            }
        }

        //poziva metodu za uzimanje rezultat
        private void ResultsReturned(IAsyncResult iar)
        {
            //pretvara objekat stanja natrag u tip delegata
            DelegateThatReturnsInt del = (DelegateThatReturnsInt)iar.AsyncState;

            //poziva EndInvoke na delegatu da uzme rezultat
            int result = del.EndInvoke(iar);

            //prikazuje rezultate
            Console.WriteLine("Delegate returned result: {0}", result);
        }
    }
}
