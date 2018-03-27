using System;
using System.IO;
namespace Primjer03
{
    class Program
    {
        private const string big = "bignumber.txt";

        static void Main()
        {
            StreamWriter fWrite = null;

            try
            {
                fWrite = new StreamWriter(big, false, System.Text.Encoding.ASCII);
                fWrite.WriteLine("milijun");
                int i = 1000000;
                fWrite.WriteLine(i);

                fWrite.WriteLine("milijarada");
                i = 1000000000;
                fWrite.WriteLine(i);

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

            StreamReader fRead = null;
            try
            {
                fRead = new StreamReader(big, System.Text.Encoding.ASCII);
                string s;
                while ((s = fRead.ReadLine()) != null)
                    Console.WriteLine(s);
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
