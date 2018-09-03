using System;
using System.Collections;

namespace PrimjerStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack brojevi = new Stack();

            //popuniti stek
            foreach (int broj in new int[] { 9, 3, 7, 2})
            {
                brojevi.Push(broj);
                Console.WriteLine(broj + " je stavljen na stek");
            }
            //proci kroz stek
            foreach (int broj in brojevi)
            {
                Console.WriteLine(broj);
            }
            //isprazni stek
            while (brojevi.Count != 0)
            {
                int broj = (int)brojevi.Pop();
                Console.WriteLine(broj + " je uklonjen sa steka");
            }
        }
    }
}
