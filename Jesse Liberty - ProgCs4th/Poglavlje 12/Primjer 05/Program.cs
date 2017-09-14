using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvokingDelegatedMethodsManually
{
    class Program
    {
        static void Main()
        {
            ClassWithDelegate theClassWithDelegate = new ClassWithDelegate();

            FirstSubscriber fs = new FirstSubscriber();
            fs.Subscribe(theClassWithDelegate);

            SecondSubscriber ss = new SecondSubscriber();
            ss.Subscribe(theClassWithDelegate);

            theClassWithDelegate.Run();
        }
    }
}
