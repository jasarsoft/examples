using System;
using System.Data.OleDb;

namespace Primjer09
{
    class Program
    {
        static void Main()
        {
            string database = "brodovi.accdb";
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                                                        "Data Source=" + database +
                                                        ";Persist Security Info=True");

            string sailBoat1 = "Brod2";
            string sailBoat2 = "Brod3";
            
            try
            {
                conn.Open();
                string sql = "UPDATE Table1 SET " + "NaDnu = ?" + " WHERE Naziv = ?";

                OleDbCommand command = new OleDbCommand(sql, conn);

                command.Parameters.Add("NaDnu", OleDbType.Boolean);
                command.Parameters.Add("Naziv", OleDbType.Char);
                command.Parameters["NaDnu"].Value = true;
                command.Parameters["Naziv"].Value = sailBoat1;
                command.ExecuteNonQuery();

                command.Parameters.Add("NaDnu", OleDbType.Boolean);
                command.Parameters.Add("Naziv", OleDbType.Char);
                command.Parameters["NaDnu"].Value = true;
                command.Parameters["Naziv"].Value = sailBoat2;
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
