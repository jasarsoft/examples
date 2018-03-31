using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructWithoutNew
{
    class Program
    {
        public struct Location
        {
            public int xVal;
            public int yVal;

            public Location(int xCooridnate, int yCoordinate)
            {
                xVal = xCooridnate;
                yVal = yCoordinate;
            }

            public int x
            {
                get { return xVal; }
                set { xVal = value; }
            }

            public int y
            {
                get { return yVal; }
                set { yVal = value; }
            }

            public override string ToString()
            {
                return (String.Format("{0}, {1}", xVal, yVal));
            }
        }

        static void Main(string[] args)
        {
            Location loc1; //nema poziva konstruktora

            loc1.xVal = 75; //incijalizaira clanove
            loc1.yVal = 22;
            Console.WriteLine(loc1);

            loc1.xVal = 75; //dodjeljuje varijablu clanicu
            loc1.yVal = 225;
            loc1.x = 300; //koristi svojstvo
            loc1.y = 400;
            Console.WriteLine(loc1);
        }
    }
}
