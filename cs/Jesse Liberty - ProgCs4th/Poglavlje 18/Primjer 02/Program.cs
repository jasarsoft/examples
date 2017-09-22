using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflection
{
    class Program
    {
        static void Main()
        {
            MyMath mm = new MyMath();
            Console.WriteLine("Calling DoFunc(7). Result: {0}\n", mm.DoFunc1(7));

            //uzima informacije o clanovima i koristi ih za uzimanje prilagodjenih atributa
            System.Reflection.MemberInfo inf = typeof(MyMath);
            object[] attributes = inf.GetCustomAttributes(typeof(BugFixAttribute), false);

            //iterira kroz atribute i uzima svojstva
            foreach(Object attribute in attributes)
            {
                BugFixAttribute bfa = (BugFixAttribute)attribute;
                Console.WriteLine("BugID: {0}", bfa.BugID);
                Console.WriteLine("Programmer: {0}", bfa.Programmer);
                Console.WriteLine("Date: {0}", bfa.Date);
                Console.WriteLine("Comment: {0}", bfa.Comment);
            }

        }
    }
}
