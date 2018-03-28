using System;
using System.Data.OleDb;


namespace Primjer08
{
    class Program
    {
        static void Main()
        {
            string database = "brodovi.accdb";
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                                                        "Data Source=" + database +
                                                        ";Persist Security Info=True");

            int id = 100;
            string name = "Rimska Galija";
            string drzava = "Rimsko Carstvo";
            double duzina = 25;
            DateTime datumPotonuca = new DateTime(200, 1, 1);
            bool naDnu = true;

            string sql = "INSERT INTO Table1 VALUES(" +
                         "\'" + id + "\'" + ", " +
                         "\'" + name + "\'" + ", " +
                         "\'" + drzava + "\'" + ", " +
                         "\'" + duzina + "\'" + ", " +
                         "\'" + datumPotonuca.Day + "." +
                         datumPotonuca.Month + "." +
                         datumPotonuca.Year + "\'" + ", " +

                         "\'" + (naDnu == false ? "0" : "1") + "\'" + ")";

            try
            {
                conn.Open();
     
                OleDbCommand command = new OleDbCommand(sql, conn);
                command.ExecuteNonQuery();
            }
            catch (OleDbException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
