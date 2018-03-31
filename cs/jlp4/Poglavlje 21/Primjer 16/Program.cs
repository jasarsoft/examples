using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WorkingWithNonSerializedObject
{
    [Serializable]
    class SumOf :IDeserializationCallback
    {
        private int startNumber = 1;
        private int endNumber;
        [NonSerialized]
        private int[] theSums;
        static void Main()
        {
            Console.WriteLine("Create first one with new...");
            SumOf app = new SumOf(1, 5);

            Console.WriteLine("Creating second one with deserialize...");
            SumOf newInstance = SumOf.DeSerialize();
            newInstance.DisplaySums();
        }

        public SumOf(int start, int end)
        {
            startNumber = start;
            endNumber = end;
            ComputeSums();
            DisplaySums();
            Serialize();
        }

        private void ComputeSums()
        {
            int count = endNumber - startNumber + 1;
            theSums = new int[count];
            theSums[0] = startNumber;
            for (int i = 1, j = startNumber + 1; i < count; i++, j++)
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

        public static SumOf DeSerialize()
        {
            FileStream fileStream = new FileStream("DoSum.out", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            SumOf retValue = (SumOf)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return retValue;
        }

        public virtual void OnDeserialization(Object sender)
        {
            ComputeSums();
        }
    }
}
