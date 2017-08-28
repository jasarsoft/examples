using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primjer_05
{
    class EnumeratedConstants
    {
        enum Temperatures
        {
            WickedCold = 0,
            FreezingPoint = 32,
            LightJacketWeather = 60,
            SwimmingWeather = 72,
            BoilingPoint = 212
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Freezing point of weater: {0}", (int)Temperatures.FreezingPoint);
            System.Console.WriteLine("Boiling point of weater: {0}", (int)Temperatures.BoilingPoint);
        }
    }
}
