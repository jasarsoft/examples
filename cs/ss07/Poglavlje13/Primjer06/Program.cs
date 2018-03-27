using System;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace Primjer06
{
    class Program
    {
        static void Main()
        {
            string url = "https://www.eurosport.com/";
            string htmlSource = null;
            StreamReader reader = null;

            try
            {
                WebRequest webZahtjev = WebRequest.Create(url);
                WebResponse webOdgovor = webZahtjev.GetResponse();

                reader = new StreamReader(webOdgovor.GetResponseStream());
                htmlSource = reader.ReadToEnd();
            }
            catch (System.Net.WebException e)
            {
                Console.WriteLine("Ne mogu se spojiti na eurosport.com");
                return;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            StreamWriter fWrite = null;
            try
            {
                string currFolder = Directory.GetCurrentDirectory();
                fWrite = new StreamWriter(currFolder + "\\eurosport.html", false, System.Text.Encoding.ASCII);
                fWrite.Write(htmlSource);

                Process ie = new Process();
                ie.StartInfo.FileName = "iexplore.exe";
                ie.StartInfo.Arguments = currFolder + "\\eurosport.html";
                ie.Start();

            }
            catch (Exception e)
            {
                Console.WriteLine("Ne mogu zapisat u datoteku");
            }
            finally
            {
                if (fWrite != null)
                    fWrite.Close();
            }
        }
    }
}
