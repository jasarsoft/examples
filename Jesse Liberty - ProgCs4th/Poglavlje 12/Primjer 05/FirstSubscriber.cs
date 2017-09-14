using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvokingDelegatedMethodsManually
{
    public class FirstSubscriber
    {
        private int myCount = 0;
        
        public void Subscribe(ClassWithDelegate theClassWithDelegate)
        {
            theClassWithDelegate.theDelegate += new ClassWithDelegate.DelegateThatReturnsInt(DisplayCounter);
        }

        public int DisplayCounter()
        {
            return ++myCount;
        }
    }
}
