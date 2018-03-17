using System;

namespace Primjer14
{
    class Program
    {
        static void Main()
        {
            bool flagImportant = false;
            Random nekiBroj = new Random();

            do
            {
                if(!flagImportant)
                {
                    flagImportant = !flagImportant;
                    //vrlo vazan kod...
                }

                //...
                //...
            } while (nekiBroj.Next(100) != 50);
        }
    }
}
