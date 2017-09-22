using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ReflectingOnMembersOfType
{
    class Program
    {
        static void Main()
        {
            //ispitivanje objekata
            Type theType = Type.GetType("System.Reflection.Assembly");
            Console.WriteLine("Single Type is {0}", theType);

            //uzima sve clanove
            //MemberInfo[] mbInfoArray = theType.GetMembers();
            MemberInfo[] mbInfoArray = theType.GetMethods();
            foreach (MemberInfo mbInfo in mbInfoArray)
            {
                Console.WriteLine("{0} is a {1}", mbInfo, mbInfo.MemberType);
            }
        }
    }
}
