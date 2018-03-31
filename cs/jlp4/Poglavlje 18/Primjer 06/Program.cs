using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace FindingPracticularMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            //ispitivanje jedan objekat
            Type theType = Type.GetType("System.Reflection.Assembly");

            //samo clanovi koji su metode na Get
            MemberInfo[] mbInfoArray = theType.FindMembers(MemberTypes.Method,
                BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly,
                Type.FilterName, "Get*");

            foreach(MemberInfo mbInfo in mbInfoArray)
            {
                Console.WriteLine("{0} is a {1}", mbInfo, mbInfo.MemberType);
            }
        }
    }
}
