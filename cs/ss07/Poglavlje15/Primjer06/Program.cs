using System;
using System.Data.OleDb;

namespace Primjer06
{
    class Program
    {
        static void Main()
        {
            string database = "brodovi.accdb";
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                                                        "Data Source=" + database +
                                                        ";Persist Security Info=True");

            try
            {
                conn.Open();
                string sql = "UPDATE Table1 SET " + "NaDnu='0'" + " WHERE Naziv = 'Brod4'";

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
