using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba_08
{
    class Program
    {
        static void Main(string[] args)
        {
            double realKoord, imagKoord;
            double realPom, imagPom, realPom2, arg;
            int iteracija;

            for(imagKoord = 1.2; imagKoord >= -1.2; imagKoord -= 0.05)
            {
                for(realKoord = -0.6; realKoord <= 1.77; realKoord += 0.03)
                {
                    iteracija = 0;
                    realPom = realKoord;
                    imagPom = imagKoord;
                    arg = (realKoord * realKoord) + (imagKoord * imagKoord);

                    while((arg < 4) && (iteracija < 40))
                    {
                        realPom2 = (realPom * realPom) - (imagPom * imagPom) - realKoord;
                        imagPom = (2 * realPom * imagPom) - imagKoord;
                        realPom = realPom2;
                        arg = (realPom * realPom) + (imagPom * imagPom);
                        iteracija += 1;
                    }

                    switch(iteracija % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }

                Console.Write("\n");
            }
        }
    }
}
