using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassingValues
{
    public class MyClass
    {
        public void SomeMethod(int firstParam, float secondParam)
        {
            Console.WriteLine("Here are the parameters received: {0}, {1}", firstParam, secondParam);
        }
    }

    class Tester
    {
        static void Main()
        {
            int howManyPeople = 5;
            float pi = 3.14F;

            MyClass mc = new MyClass();
            mc.SomeMethod(howManyPeople, pi);
        }
    }
}
