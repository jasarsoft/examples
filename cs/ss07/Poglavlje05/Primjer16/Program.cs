using System;

namespace Westinghouse
{
    class Generator
    {
        private float powerMW;

        public Generator(float f)
        {
            powerMW = f;
        }
    }
}

namespace Koncar
{
    class Generator
    {
        private float snagaMW;

        public Generator(float f)
        {
            snagaMW = f;
        }
    }
}

namespace Primjer16
{
    class Program
    {
        static void Main()
        {
            Westinghouse.Generator w = new Westinghouse.Generator(100);
        }
    }
}
