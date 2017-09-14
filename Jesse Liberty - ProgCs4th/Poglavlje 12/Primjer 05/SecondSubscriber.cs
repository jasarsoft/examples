using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvokingDelegatedMethodsManually
{
    public class SecondSubscriber
    {
        private int myCounter = 0;

        public void Subscribe(ClassWithDelegate theClassWithDelegate)
        {
            theClassWithDelegate.theDelegate += new ClassWithDelegate.DelegateThatReturnsInt(Doubler);
        }

        public int Doubler()
        {
            return myCounter += 2;
        }
    }
}
