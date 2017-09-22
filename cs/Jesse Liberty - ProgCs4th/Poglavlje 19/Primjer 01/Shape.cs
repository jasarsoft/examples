using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marshaling
{
    //klasa Shape rasporedjuje po referenci
    public class Shape : MarshalByRefObject
    {
        private Point upperLeft;

        public Shape(int upperLeftX, int upperLeftY)
        {
            Console.WriteLine("[{0}] {1}", System.AppDomain.CurrentDomain.FriendlyName, "Shape construtor");
            upperLeft = new Point(upperLeftX, upperLeftY);
        }

        public Point GetUpperLeft()
        {
            return upperLeft;
        }

        public void ShowUpperLeft()
        {
            Console.WriteLine("[{0}] Upper left: {1}, {2}", 
                System.AppDomain.CurrentDomain.FriendlyName, upperLeft.X, upperLeft.Y);
        }
    }
}
