using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Primjer_15
{
    [Serializable]
    class Program
    {
        private int startNumber = 1;
        private int endNumber;
        private int[] theSums;
        static void Main()
        {
            Console.WriteLine("Create first one with new...");
            Program app = new Program(1, 10);

        }

        public Program(int start, int end)
        {
            startNumber = start;
            endNumber = end;
            ComputeSums();
            DisplaySums();
            Serialize();
            Console.ReadKey();
            DeSerialize();
        }

        private void ComputeSums()
        {
            int count = endNumber - startNumber + 1;
            theSums = new int[count];
            theSums[0] = startNumber;
            for(int i = 1, j = startNumber + 1; i < count; i++ , j++)
            {
                theSums[i] = j + theSums[i - 1];
            }
        }

        private void DisplaySums()
        {
            foreach (int i in theSums)
                Console.WriteLine("{0}, ", i);
        }

        private void Serialize()
        {
            Console.Write("Serializing...");
            //stvara tok podatak za zapisivanje datoteke
            FileStream fileStream = new FileStream("DoSum.out", FileMode.Create);
            //koristi binarni formater CLR-a
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            //serijaliziranje na disk
            binaryFormatter.Serialize(fileStream, this);
            Console.WriteLine("...completed");
            fileStream.Close();
        }

        public static Program DeSerialize()
        {
            FileStream fileStream = new FileStream("DoSum.out", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Program retValue = (Program)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return retValue;
        }
    }
}
