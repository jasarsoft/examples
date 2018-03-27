using System;
using System.IO;

namespace Primjer04
{
    class Program
    {
        private const string big = "bignumber.bin";

        static void Main()
        {
            Stream izlazniTok = File.OpenWrite(big);
            BinaryWriter fWrite = null;

            try
            {
                fWrite = new BinaryWriter(izlazniTok);
                fWrite.Write("milijun");
                int i = 1000000;
                fWrite.Write(i);

                fWrite.Write("milijarada");
                i = 1000000000;
                fWrite.Write(i);

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

                Console.WriteLine(fRead.ReadString());
                Console.WriteLine(fRead.ReadInt32());
                Console.WriteLine(fRead.ReadString());
                Console.WriteLine(fRead.ReadInt32());
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