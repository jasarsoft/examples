using System;

namespace Primjer13
{
    class Program
    {
        static void Main()
        {
            bool flagImportant = false;
            Random nekiBroj = new Random();

            while(nekiBroj.Next(100) != 50)
            {
                if(flagImportant)
                {
                    flagImportant = true;
                    //vazan kod...
                }

                //....
            }
        }
    }
}
