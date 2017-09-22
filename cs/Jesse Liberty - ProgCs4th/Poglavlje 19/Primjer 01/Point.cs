using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marshaling
{
    //za rasporedjivanje po referenci smjestite u komentar atribut
    //a izdvojite iz koemntara osnvnu klasu
    [Serializable]
    public class Point //: MarshalByRefObject
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            Console.WriteLine("[{0}] {1}", System.AppDomain.CurrentDomain.FriendlyName, "Point Constructor");
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get
            {
                Console.WriteLine("[{0}] {1}", System.AppDomain.CurrentDomain.FriendlyName, "Point x.get");
                return this.x;
            }
            set
            {
                Console.WriteLine("[{0}] {1}", System.AppDomain.CurrentDomain.FriendlyName, "Point x.set");
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                Console.WriteLine("[{0}] {1}", System.AppDomain.CurrentDomain.FriendlyName, "Point y.get");
                return this.y;
            }
            set
            {
                Console.WriteLine("[{0}] {1}", System.AppDomain.CurrentDomain.FriendlyName, "Point y.set");
                this.y = value;
            }
        }


    }
}
