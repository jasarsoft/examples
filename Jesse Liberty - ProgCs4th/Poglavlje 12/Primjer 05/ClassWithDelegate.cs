using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace InvokingDelegatedMethodsManually
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
                        int result = del();
                        Console.WriteLine("Delegates fired! Return result: {0}", result);
                    }
                    Console.WriteLine();
                }
                
            }
        }
    }
}
