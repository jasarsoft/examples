using System;

namespace Primjer02
{
    class MobileDevice
    {
        private string opSustav;
        private float marketShare;

        public MobileDevice(string os)
        {
            opSustav = os;
        }

        public float MarketShare
        {
            get { return marketShare; }
            set { marketShare = value; }
        }

        public string OPSustav
        {
            get { return opSustav; }
            set { opSustav = value; }
        }
    }

    class Program
    {
        static MobileDevice[] SetMarketShare(MobileDevice[] arr)
        {
            arr[0].MarketShare = 45;
            arr[1].MarketShare = 35;
            arr[2].MarketShare = 20;

            return arr;
        }

        static void Main()
        {
            MobileDevice[] gadgets = new MobileDevice[3];
            gadgets[0] = new MobileDevice("Palm OS");
            gadgets[1] = new MobileDevice("Pocket PC");
            gadgets[2] = new MobileDevice("Symbian");

            gadgets = SetMarketShare(gadgets);

            for (int i = 0; i < 3; i++)
                Console.WriteLine(gadgets[i].OPSustav + " - " + gadgets[i].MarketShare + "%");
        }
    }
}
