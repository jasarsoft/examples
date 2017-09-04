﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreatingAStruct
{
    public struct Location
    {
        private int xVal;
        private int yVal;

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

    class Tester
    {
        public void myFunc(Location loc)
        {
            loc.x = 50;
            loc.y = 100;
            Console.WriteLine("In myFunc loc: {0}", loc.ToString());
        }

        static void Main()
        {
            Location loc1 = new Location(200, 300);
            Console.WriteLine("Loc1 location: {0}", loc1.ToString());
            Tester t = new Tester();
            t.myFunc(loc1);
            Console.WriteLine("Loc1 location: {0}", loc1);
        }
    }
}
