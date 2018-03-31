using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AsyncDelegate
{
    public class FirstSubscriber
    {
        private int myCount = 0;
        
        public void Subscribe(ClassWithDelegate theClassWithDelegate)
        {
            theClassWithDelegate.theDelegate += new ClassWithDelegate.DelegateThatReturnsInt(DisplayCounter);
            //theClassWithDelegate.theDelegate += delegate ()
            //{
            //    Console.WriteLine("Busy in DisplayCounter...");
            //    Thread.Sleep(4000);
            //    Console.WriteLine("Done with work in DisplayCounter...");
            //    return ++myCount;
            //};
        }

        public int DisplayCounter()
        {
            Console.WriteLine("Busy in DisplayCounter...");
            Thread.Sleep(10000);
            Console.WriteLine("Done wiht work in DisplyCounter...");
            return ++myCount;
        }
    }
}
