using System;

namespace Primjer06
{
    class Program
    {
        static void Main()
        {
            string text;
            int exponent = 6;

            switch (exponent)
            {
                case -12:
                    text = "piko";
                    break;
                case -9:
                    text = "nano";
                    break;
                case -6:
                    text = "mikro";
                    break;
                case -3:
                    text = "mili";
                    break;
                case 3:
                    text = "kilo";
                    break;
                case 6:
                    text = "mega";
                    break;
                case 9:
                    text = "giga";
                    break;
                case 12:
                    text = "tera";
                    break;
                default:
                    text = exponent < 0 ? "premala velicina" : "prevelika velicina";
                    break;
            }

            Console.WriteLine(text);
        }
    }
}
