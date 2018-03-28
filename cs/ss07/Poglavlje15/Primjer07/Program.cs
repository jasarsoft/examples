using System;
using System.Data.OleDb;

namespace Primjer07
{
    class Program
    {
        static void Main()
        {
            string ship = "Brod4";
            string database = "brodovi.accdb";
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                                                        "Data Source=" + database +
                                                        ";Persist Security Info=True");

            try
            {
                conn.Open();
                string sql = "DELETE FROM Table1 WHERE Naziv = " + "\'" + ship + "\'";

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
