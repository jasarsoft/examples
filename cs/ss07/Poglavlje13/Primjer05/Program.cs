using System;
using System.IO;

namespace Primjer05
{
    class Program
    {
        private const string big = "bignumber.bin";


        static void Main()
        {
            double[] constants = new double[]
            {
                1.60217653,
                3.1415926,
                2.718,
                9.80665,
                6.6742
            };

            Stream izlazniTok = File.OpenWrite(big);
            BinaryWriter fWrite = null;

            try
            {
                fWrite = new BinaryWriter(izlazniTok);
                foreach (double d in constants)
                    fWrite.Write(d);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fWrite != null)
                    fWrite.Close();
            }

            Stream ulazniTok = File.OpenRead(big);
            BinaryReader fRead = null;

            try
            {
                fRead = new BinaryReader(ulazniTok);
                while (ulazniTok.Position < ulazniTok.Length)
                    Console.WriteLine(fRead.ReadDouble());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fRead != null)
                    fRead.Close();
            }

            FileInfo f = new FileInfo(big);
            Console.WriteLine(f.Length + " bytes");
        }
    }
}
