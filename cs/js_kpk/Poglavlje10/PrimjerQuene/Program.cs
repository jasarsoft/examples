using System;
using System.Collections;


namespace PrimjerQuene
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue brojevi = new Queue();

            //popuniti red za cekanje
            foreach(int broj in new int[] { 9, 3, 7, 3})
            {
                brojevi.Enqueue(broj);
                Console.WriteLine(broj + " je dodat u red");
            }
            //proci kroz red
            foreach (int broj in brojevi)
            {
                Console.WriteLine(broj);
            }
            //isprazniti red
            while(brojevi.Count != 0)
            {
                int broj = (int)brojevi.Dequeue();
                Console.WriteLine(broj + " je izbacen iz reda");
            }
        }
    }
}
