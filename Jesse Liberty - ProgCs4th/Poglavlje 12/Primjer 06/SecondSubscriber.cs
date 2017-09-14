using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsyncDelegate
{
    public class SecondSubscriber
    {
        private int myCounter = 0;

        public void Subscribe(ClassWithDelegate theClassWithDelegate)
        {
            theClassWithDelegate.theDelegate += new ClassWithDelegate.DelegateThatReturnsInt(Doubler);
            //theClassWithDelegate.theDelegate += delegate ()
            //{
            //    return myCounter += 2;
            //};
        }

        public int Doubler()
        {
            return myCounter += 2;
        }
    }
}
