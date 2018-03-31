using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraySortAndReverse
{
    class Program
    {
        static void Main()
        {
            String[] myArray =
            {
                "Who", "is", "John", "Galt"
            };

            Tester.PrintArray(myArray);
            Array.Reverse(myArray);
            Tester.PrintArray(myArray);

            String[] myOtherArray =
            {
                "We", "Hold", "These", "Truths",
                "To", "Be", "Self", "Evident"
            };

            Console.WriteLine();
            Tester.PrintArray(myOtherArray);
            Array.Sort(myOtherArray);
            Tester.PrintArray(myOtherArray);
        }
    }
}
