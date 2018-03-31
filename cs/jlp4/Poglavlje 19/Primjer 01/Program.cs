using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Marshaling
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("[{0}] {1}", System.AppDomain.CurrentDomain.FriendlyName, "Entered Main");

            //stvara novu aplikacijsku domenu
            AppDomain ad2 = AppDomain.CreateDomain("Shape Domain");

            //Assembly a = Assambly.LoadForm("ProgCSharp.exe");
            //Object theShape = a.CreateInstance("Shape");
            //Instanciranje Shape objekta
            System.Runtime.Remoting.ObjectHandle oh = ad2.CreateInstance(
                "Marshaling",
                "Marshaling.Shape", false,
                BindingFlags.CreateInstance,
                null, new object[] { 3, 5 }, null, null);


            Shape s1 = (Shape)oh.Unwrap();
            s1.ShowUpperLeft(); //zahtjeva od objekta da prikaze

            //dobili ste lokalnu kopiju posrednika
            Point localPoint = s1.GetUpperLeft();

            //dodjeljuje nove vrijednosti
            localPoint.X = 500;
            localPoint.Y = 600;

            //prikazuje vrijednosti lokalnog pointa
            Console.WriteLine("[{0}] localPoint: {1}, {2}", System.AppDomain.CurrentDomain.FriendlyName, localPoint.X, localPoint.Y);

            s1.ShowUpperLeft(); //prikazuje vrijednost jos jednom
        }
    }
}
