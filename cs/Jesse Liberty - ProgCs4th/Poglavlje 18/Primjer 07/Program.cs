using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace DynamicallyInvokingAMethod
{
    class Program
    {
        static void Main()
        {
            Type theMathType = Type.GetType("System.Math");
            //ako System.Math ima javni kontruktor izbacit ce iznimku
            //Object theObj = Activator.CreateInstance(theMathType);

            //polje s jednim clanom
            Type[] paramTypes = new Type[1];
            paramTypes[0] = Type.GetType("System.Double");

            //uzima informacije o metodi Cos()
            MethodInfo cosInfo = theMathType.GetMethod("Cos", paramTypes);

            //popunjava polje sa stvarnim parametrima
            Object[] parameters = new object[1];
            parameters[0] = 45 * (Math.PI / 180); //45 stupnjeva u radijanima
            Object returnVal = cosInfo.Invoke(theMathType, parameters);
            Console.WriteLine("The cosine of a 45 degree angle {0}", returnVal);
        }
    }
}
